

require "define"
require "ui/ui_mgr"

function main()

    local clientmodelmgr = require("clientmodel.clientmodelmgr")
    clientmodelmgr.register()

    --- C#消息回调注册
    local netmsgregister = require "msgdispatcher.netmsgregister"
    netmsgregister.init();

    local testui = require("ui.uiview.ui_test.ui_test")
    testui.show();

end

main();













--print("123", "456", 420, "王虎", 1.35)

--local util = require '3rd/xlua/util'
--util.print_func_ref_by_csharp()





