---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 6:33
---

---@type msgdispatcher
local msgdispatcher = require("msgdispatcher.msgdispatcher")

local netmsgregister = require("msgdispatcher.netmsgregister")

local selectserverstate = require("gamestate.selectserverstate")
selectserverstate.evententer:Connect(function ()
    print("selectservermodel.show")

    local ui_selectserver = require("ui.ui_selectserver.ui_selectserver")
    ui_selectserver.show()
end)

---@class selectservermodel
selectservermodel = {}


---------------------------------------继承函数---------------------------------------

function selectservermodel.create()

end

function selectservermodel.close()

end

--------------------------------------------------------------------------------------


return selectservermodel;
