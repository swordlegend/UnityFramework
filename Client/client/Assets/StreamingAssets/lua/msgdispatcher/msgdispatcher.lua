local flatbuffers = require("3rd/flatbuffers");

---@type netmsg
local netmsg = require 'msgdispatcher/netmsg'

---@class msgdispatcher
msgdispatcher = {

}

msgdispatcher.msgType = {
    flatbuffer = 0,
    protobuf = 1,
}

---@class builder
function msgdispatcher.newBuilder(len)
    return flatbuffers.Builder(len)
end

msgdispatcher.curMsgType = msgdispatcher.msgType.flatbuffer;

-- 消息分发
msgdispatcher.dispatcher = function(msgid, bytearray)

    if msgdispatcher.curMsgType == msgdispatcher.msgType.flatbuffer then
        msgdispatcher.dispatcherFbMsg(msgid, bytearray);
    end
end

-- fb消息注册
msgdispatcher.registerFbMsg = function(msg, handler)
    netmsg.AddListener(msg, handler);
end

-- fb消息取消注册
msgdispatcher.unRegisterFbMsg = function(msg, handler)
    netmsg.RemoveListener(msg, handler);
end

-- 发送fb消息
msgdispatcher.sendFbMsg = function(msg, builder)

    local msgbytes = builder:Output();
    local msgid = msg.HashID;
    local msglen = #msgbytes + 8;

    local bytebuf = global.ByteBuffer();
    msglen = global.Converter.GetBigEndianUInt16(msglen)
    bytebuf:WriteShort(msglen);
    bytebuf:WriteUlong(msgid)
    bytebuf:WriteBytes(msgbytes, 0, #msgbytes)
    global.INetManager:SendMessage(bytebuf);
end

-- fb消息分发
msgdispatcher.dispatcherFbMsg = function(msgid, bytearray)

    local msgbuf = flatbuffers.binaryArray.New(bytearray);

    local eventlib = netmsg.findNetData(msgid);
    if not eventlib then
        return ;
    end

    local msgclass = eventlib.msgclass;
    if not msgclass then
        return ;
    end

    local msg = msgclass.init(msgbuf, 0);
    if not msg then
        return ;
    end

    netmsg.Brocast(msgid, msg);
end

return msgdispatcher;














--local bufAsString = builder:Output();
--local msgid = msg.HashID;
--local strwrite = string.pack("<L", msgid);
--strwrite = strwrite .. bufAsString;
--local package = string.pack("<s2", strwrite)
--local bytebuf = global.ByteBuffer();
--bytebuf:WriteBytes(package, 0, #package);
--global.INetManager:SendMessage(bytebuf);

--@class builder
--msgdispatcher.builder = flatbuffers.Builder(1024)