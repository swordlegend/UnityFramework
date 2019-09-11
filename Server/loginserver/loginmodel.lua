local skynet = require "skynet"

---@type msgdispatcher
local msgdispatcher = require "msgdispatcher";

---@type ReqRegisterAccount
local reqregacc = require("ReqRegisterAccount")

---@type RspRegisterAccount
local rspregacc = require("RspRegisterAccount")

local reqloginacc = require("ReqLoginAccount")

local rsploginacc = require("RspLoginAccount")

local rsploginzonelist = require("RspLoginZoneList")

local loginzonelist = require("LoginZoneList")

local zonelist = {
    {
        id = 1,
        name = "macbook",
        ip = "192.168.0.108",
        port = "6000"
    },
    {
        id = 2,
        name = "vultr",
        ip = "207.246.94.233",
        port = "6000"
    }
}

---@class loginmodel
loginmodel = {}

loginmodel.register = function()
    print("loginmodel.register")

    msgdispatcher.registerFbMsg(reqregacc, loginmodel.onReqRegAcc_cs)
    msgdispatcher.registerFbMsg(reqloginacc, loginmodel.onReqLoginAcc_cs)
end

loginmodel.unRegister = function()
    msgdispatcher.unRegisterFbMsg(reqregacc, loginmodel.onReqRegAcc_cs)
    msgdispatcher.unRegisterFbMsg(reqloginacc, loginmodel.onReqLoginAcc_cs)
end




---------------------------------消息-------------------------------------------

loginmodel.onReqLoginAcc_cs = function(data)
    print("loginmodel.onReqLoginAcc_cs")

    local id = data.id
    local reqlogindata = data.msg

    local account = reqlogindata:Account()
    local password = reqlogindata:Password()

    local dbmanager = skynet.queryservice "dbmanager"
    local issucceed, result = skynet.call(dbmanager, "lua", "select_one_by_key", "account", "account", account)
    if not result then
        print("loginmodel.onReqLoginAcc_cs " .. account .. " queue failed !")
        return
    end

    -- rsploginacc

    local builder = msgdispatcher.newBuilder(1024)
    rsploginacc.Start(builder)
    rsploginacc.AddOk(builder, 1)

    local orc = rsploginacc.End(builder)
    builder:Finish(orc)

    msgdispatcher.sendFbMsg(id, rsploginacc, builder)

    -- rsploginzonelist

    builder = msgdispatcher.newBuilder(1024)

    local zonelistcnt = #zonelist

    local zonetemplistorc = {}
    for idx = 1, zonelistcnt do
        local zone = zonelist[idx]

        local strname = builder:CreateString(zone.name)
        local strip = builder:CreateString(zone.ip)
        local strport = builder:CreateString(zone.port)

        loginzonelist.Start(builder)
        loginzonelist.AddId(builder, zone.id)
        loginzonelist.AddName(builder, strname)
        loginzonelist.AddIp(builder, strip)
        loginzonelist.AddPort(builder, strport)

        local zoneorc = loginzonelist.End(builder)
        table.insert(zonetemplistorc, zoneorc)
    end

    rsploginzonelist.StartZonelistVector(builder, zonelistcnt)
    for idx = #zonetemplistorc, 1, -1 do
        builder:PrependUOffsetTRelative(zonetemplistorc[idx])
    end
    local zonelistorc = builder:EndVector(zonelistcnt)

    rsploginzonelist.Start(builder)
    rsploginzonelist.AddZonelist(builder, zonelistorc)

    local orc = rsploginzonelist.End(builder)
    builder:Finish(orc)

    msgdispatcher.sendFbMsg(id, rsploginzonelist, builder)
end

loginmodel.onReqRegAcc_cs = function(data)
    print("loginmodel.onReqRegAcc_cs")

    local id = data.id
    local reqregdata = data.msg

    local account = reqregdata:Account()
    local password = reqregdata:Password()
    --print(account);
    --print(password);

    local dbmanager = skynet.queryservice "dbmanager"
    local issucceed, result = skynet.call(dbmanager, "lua", "select_one_by_key", "account", "account", account)
    if result and result[1] then
        print("loginmodel.onReqRegAcc_cs " .. account .. " exist !")
        return
    end

    skynet.call(dbmanager, "lua", "insert", "account", { account = account, password = password })

    local issucceed, result = skynet.call(dbmanager, "lua", "select_one_by_key", "account", "account", account)
    if not result then
        print("loginmodel.onReqRegAcc_cs " .. account .. " create failed !")
        return
    end

    local builder = msgdispatcher.newBuilder(1024);
    rspregacc.Start(builder)
    rspregacc.AddOk(builder, 1)

    local orc = rspregacc.End(builder)
    builder:Finish(orc)

    msgdispatcher.sendFbMsg(id, rspregacc, builder);
end

return loginmodel;