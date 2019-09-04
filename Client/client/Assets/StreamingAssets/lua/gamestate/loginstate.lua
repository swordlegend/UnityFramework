---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 12:19
---

local basestate = require("gamestate.basestate")

---@class loginstate
local loginstate = luaclass(basestate);

function loginstate.onEnter()
    print("loginstate.onEnter")

    basestate.onEnter()
end

function loginstate.onExit()
    print("loginstate.onExit")

    basestate.onExit()
end

function loginstate.onRefresh()
    print("loginstate.onRefresh")

    basestate.onRefresh()
end

return loginstate:new()