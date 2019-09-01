

local skynet = require "skynet"

local service = require "service"

local msgdispatcher = require "msgdispatcher"

local chatmodel = require "chatmodel"

local loginmodel = require "loginmodel"

local msgregister = {}

local data = {}

function msgregister.register()
    print("msgregister.register")

    loginmodel.register();
    chatmodel.register();
end

function msgregister.dipatcher(client_fd, msg, sz)
    msgdispatcher.dispatcherFbMsg(client_fd, msg, sz);
end

function msgregister.rspconnectsuc(client_fd)
    loginmodel.rspconnectsuc_sc(client_fd)
end

service.init {
    command = msgregister,
    info = data
}
