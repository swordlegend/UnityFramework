---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by xieliujian.
--- DateTime: 2019/9/1 6:21
---

---@class ui_login
ui_login = {}

ui_login.uiname = "ui_panel_login"

---@type testmodel
ui_login.model = nil

----------------------------------------------内置-------------------------------------------------

function ui_login.show()

    if ui_login.isShow then
        return;
    end

    ---@type gtmGame.Dialog
    ui_login.dialog = ui_mgr.createDialog(ui_login.uiname, "ui_login");

    if not ui_login.dialog then
        print("ui_login.dialog null uiname " .. ui_login.uiname);
    end

    ui_login.isShow = true;

    ui_login.initui();
    ui_login.initEvent();
end

function ui_login.close()
    ui_mgr.closeDialog(ui_login.uiname);
end

function ui_login.preShow()
    print("ui_login.preShow")
end

function ui_login.preHide()
    print("ui_login.preHide")
end

function ui_login.preClose()
    print("ui_login.preClose")

    ui_login.isShow = false;
    ui_login.uiref = {};
end

--- initui
function ui_login.initui()
    ui_login.uiref = {};

    local root = ui_login.dialog.rootDialog

    ---@type CS.UnityEngine.UI.InputField
    ui_login.uiref.input_account = ui_login.dialog:GetInputFieldInChild(root, "input_account")

    ---@type CS.UnityEngine.UI.InputField
    ui_login.uiref.input_password = ui_login.dialog:GetInputFieldInChild(root, "input_password")

    ui_login.uiref.btn_confirm = ui_login.dialog:GetButtonInChild(root, "btn_confirm")
end

--- init event
function ui_login.initEvent()
    ui_login.dialog:AddBtnClickListener(ui_login.uiref.btn_confirm, ui_login.onConfirmBtnClick)
end

--------------------------------------------------------------------------------------------------












-------------------------------------------ui事件-------------------------------------------------

function ui_login.onConfirmBtnClick()
    print("ui_login.onConfirmBtnClick")

    --ui_login.dialog:SetInteractable(ui_login.uiref.btn_confirm, false)

    local account = ui_login.uiref.input_account.text
    if not account then
        return
    end

    local password = ui_login.uiref.input_password.text
    if not password then
        return
    end

    loginmodel.sendreqlogin_cs(account, password)
end

--------------------------------------------------------------------------------------------------















return ui_login;