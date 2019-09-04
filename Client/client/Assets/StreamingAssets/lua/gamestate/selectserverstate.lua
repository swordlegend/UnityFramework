---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 12:19
---

local basestate = require("gamestate.basestate")

---@class selectserverstate
local selectserverstate = luaclass(basestate);

function selectserverstate.onEnter()
    print("selectserverstate.onEnter")

    basestate.onEnter()
end

function selectserverstate.onExit()
    print("selectserverstate.onExit")

    basestate.onExit()
end

function selectserverstate.onRefresh()
    print("selectserverstate.onRefresh")

    basestate.onRefresh()
end

return selectserverstate:new()