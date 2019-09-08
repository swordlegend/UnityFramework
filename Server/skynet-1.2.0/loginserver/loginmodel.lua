
---@type msgdispatcher
local msgdispatcher = require "msgdispatcher";

---@type ReqRegisterAccount
local reqregacc = require("game.msg.fbs.ReqRegisterAccount")

---@type RspRegisterAccount
local rspregacc = require("game.msg.fbs.RspRegisterAccount")

---@class loginmodel
loginmodel = {}

loginmodel.register = function()
    print("loginmodel.register")

    msgdispatcher.registerFbMsg(reqregacc, loginmodel.onReqRegAcc_cs);
end

loginmodel.unRegister = function()
    msgdispatcher.unRegisterFbMsg(reqregacc, loginmodel.onReqRegAcc_cs);
end

-- 消息
loginmodel.onReqRegAcc_cs = function(data)
    print("loginmodel.onReqRegAcc_cs")

    local id = data.id;
    local reqlogindata = data.msg;

    print(reqlogindata:Account());
    print(reqlogindata:Password());

    local builder = msgdispatcher.newBuilder(1024);
    rspregacc.Start(builder)
    rspregacc.AddOk(builder, true)
    local orc = rspregacc.End(builder);
    builder:Finish(orc);

    msgdispatcher.sendFbMsg(id, rspregacc, builder);
end

return loginmodel;