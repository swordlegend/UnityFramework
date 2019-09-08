-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: fbs

local flatbuffers = require('3rd.flatbuffers')

---@class RspLoginZoneList
local RspLoginZoneList = {} -- the module

local RspLoginZoneList_mt = {} -- the class metatable

RspLoginZoneList.HashID = 0xEBDDB73615309BE9;

function RspLoginZoneList.New()
    local o = {}
    setmetatable(o, {__index = RspLoginZoneList_mt})
    return o
end

function RspLoginZoneList.GetRootAsRspLoginZoneList(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = RspLoginZoneList.New()
    o:Init(buf, n + offset)
    return o
end

function RspLoginZoneList.init(buf, offset)
    return RspLoginZoneList.GetRootAsRspLoginZoneList(buf, offset)
end

function RspLoginZoneList_mt:
Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end

function RspLoginZoneList_mt:Zonelist(j)
    local o = self.view:Offset(4)
    if o ~= 0 then
        local x = self.view:Vector(o)
        x = x + ((j-1) * 4)
        x = self.view:Indirect(x)
        local obj = require('msg.fbs.LoginZoneList').New()
        obj:Init(self.view.bytes, x)
        return obj
    end
end

function RspLoginZoneList_mt:ZonelistLength()
    local o = self.view:Offset(4)
    if o ~= 0 then
        return self.view:VectorLen(o)
    end
    return 0
end

function RspLoginZoneList.Start(builder) builder:StartObject(1) end
function RspLoginZoneList.AddZonelist(builder, zonelist) builder:PrependUOffsetTRelativeSlot(0, zonelist, 0) end
function RspLoginZoneList.StartZonelistVector(builder, numElems) return builder:StartVector(4, numElems, 4) end
function RspLoginZoneList.End(builder) return builder:EndObject() end

return RspLoginZoneList -- return the module