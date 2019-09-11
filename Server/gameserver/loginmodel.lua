local skynet = require "skynet"

---@type msgdispatcher
local msgdispatcher = require "msgdispatcher";

---@type RepLoginGame
local replogingame = require("RepLoginGame")

---@type RspLoginGame
local rsplogingame = require("RspLoginGame")


---@class loginmodel
loginmodel = {}

loginmodel.register = function()
    print("loginmodel.register")

    msgdispatcher.registerFbMsg(replogingame, loginmodel.onRepLoginGame_sc)
end

loginmodel.unRegister = function()

    msgdispatcher.unRegisterFbMsg(replogingame, loginmodel.onRepLoginGame_sc)
end




---------------------------------消息-------------------------------------------

function loginmodel.onRepLoginGame_sc(data)
    print("loginmodel.onRepLoginGame_sc")

    local id = data.id

    local builder = msgdispatcher.newBuilder(1024);
    rsplogingame.Start(builder)

    local orc = rsplogingame.End(builder)
    builder:Finish(orc)

    msgdispatcher.sendFbMsg(id, rsplogingame, builder)
end

--------------------------------------------------------------------------------




return loginmodel