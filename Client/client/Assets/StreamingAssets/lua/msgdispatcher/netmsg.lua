local event = require "base/event"

---@class netmsg
netmsg = {}

netmsg.netdatalist = {}

function netmsg.findNetData(msgid)
    return netmsg.netdatalist[msgid];
end

function netmsg.genNetData(msgid, msg)
    local netdata = netmsg.findNetData(msgid)
    if netdata then
        return netdata;
    end

    local newnetdata = {}
    newnetdata.msgclass = msg
    newnetdata.event = event:new()
    netmsg.netdatalist[msgid] = newnetdata

    return newnetdata
end

function netmsg.AddListener(msg, handler)

    local msgid = msg.HashID;
    local eventdata = netmsg.genNetData(msgid, msg)
    if not eventdata then
        error(true, "netmsg.AddListener  " .. msgid)
    end

    eventdata.event:AddHandler(handler)
end

function netmsg.Brocast(msgid, data)

    local netdata = netmsg.findNetData(msgid)
    if not netdata then
        print("brocast " .. msgid .. " has no event.")
    else
        netdata.event(data)
    end
end

function netmsg.RemoveListener(msg, handler)

    local msgid = msg.HashID;
    local netdata = netmsg.findNetData(msgid)

    if not netdata then
        error("remove " .. msgid .. " has no event.")
    else
        netdata.event:RemoveHandler(handler)
    end
end

return netmsg