

require "define"
require "ui/ui_mgr"

function main()

    local gamestatemgr = require("gamestate.gamestatemgr")
    gamestatemgr.register()

    local clientmodelmgr = require("clientmodel.clientmodelmgr")
    clientmodelmgr.register()

    -- C#消息回调注册
    local netmsgregister = require "msgdispatcher.netmsgregister"
    netmsgregister.init()

    gamestatemgr.changeState(global.gamestatetype.login)
end

main();











-- 连接登录服务器
--global.INetManager:SendConnect("192.168.0.108", 5000)

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





