---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/8/11 22:31
---

-- 每个服务独立, 都需要引入skynet
local skynet = require "skynet"

-- 这里可以编写各种服务处理函数

skynet.start(function()
    print("==========Service1 Start=========")
    -- 这里可以编写服务代码，使用skynet.dispatch消息分发到各个服务处理函数（后续例子再说）


end)
