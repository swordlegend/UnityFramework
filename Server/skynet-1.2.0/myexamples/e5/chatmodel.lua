
---@type msgdispatcher
local msgdispatcher = require("msgdispatcher");

---@type ReqChat
local reqchat = require("ReqChat");

---@type RspLogin
local rspchat = require "RspChat";


---@class chatmodel
chatmodel = {}

chatmodel.register = function()
    msgdispatcher.registerFbMsg(rspchat, chatmodel.rspchat_cs);
end

chatmodel.unRegister = function()
    msgdispatcher.unRegisterFbMsg(rspchat, chatmodel.rspchat_cs);
end

-- 消息
chatmodel.rspchat_cs = function(data)

    local id = data.id;
    local reqchat = data.msg;

    local builder = msgdispatcher.builder;
    local say = builder:CreateString("wow");

    rspchat.Start(builder)
    rspchat.Say(say);
    local orc = rspchat.End(builder);
    builder:Finish(orc);

    msgdispatcher.sendFbMsg(id, rspchat);
end

return chatmodel;