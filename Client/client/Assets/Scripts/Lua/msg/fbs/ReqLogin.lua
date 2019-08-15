-- automatically generated by the FlatBuffers compiler, do not modify

-- namespace: fbs

local flatbuffers = require('flatbuffers')

---@class ReqLogin
local ReqLogin = {} -- the module

local ReqLogin_mt = {} -- the class metatable


function ReqLogin.New()
    local o = {}
    setmetatable(o, {__index = ReqLogin_mt})
    return o
end

function ReqLogin.GetRootAsReqLogin(buf, offset)
    local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
    local o = ReqLogin.New()
    o:Init(buf, n + offset)
    return o
end

function ReqLogin_mt:
Init(buf, pos)
    self.view = flatbuffers.view.New(buf, pos)
end

function ReqLogin_mt:Account()
    local o = self.view:Offset(4)
    if o ~= 0 then
        return self.view:String(o + self.view.pos)
    end
end

function ReqLogin_mt:Password()
    local o = self.view:Offset(6)
    if o ~= 0 then
        return self.view:String(o + self.view.pos)
    end
end

function ReqLogin.Start(builder) builder:StartObject(2) end
function ReqLogin.AddAccount(builder, account) builder:PrependUOffsetTRelativeSlot(0, account, 0) end
function ReqLogin.AddPassword(builder, password) builder:PrependUOffsetTRelativeSlot(1, password, 0) end
function ReqLogin.End(builder) return builder:EndObject() end

return ReqLogin -- return the module