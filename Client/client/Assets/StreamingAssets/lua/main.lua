

require "define"
require "ui/ui_mgr"

function main()

    local clientmodelmgr = require("clientmodel.clientmodelmgr")
    clientmodelmgr.register()

    --- C#消息回调注册
    local netmsgregister = require "msgdispatcher.netmsgregister"
    netmsgregister.init()

    local gamestatemgr = require("gamestate.gamestatemgr")
    gamestatemgr.register()
    gamestatemgr.changeState(global.gamestatetype.login)
end

main();













--local testui = require("ui.ui_test.ui_test")
--testui.show();

--local testui = require("3rd.flatbuffers")
--local testui = require("3rd.flatbuffers")
--
--local ui_template = require("ui.ui_template")
--local ui_template = require("ui.ui_template")
--local ui_template = require("ui.ui_template")

-- need to update the Lua path to point to the local flatbuffers implementation
--package.path = string.format("3rd/?.lua;%s",package.path)
--print(package.path)

--print("123", "456", 420, "王虎", 1.35)

--local util = require '3rd/xlua/util'
--util.print_func_ref_by_csharp()





