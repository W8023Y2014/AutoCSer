﻿/// <reference path = "../../../AutoCSer/Js/base.page.ts" />
/// <reference path = "../ViewJs/Api.ts" />
AutoCSer.Pub.OnLoad(function () {
    AutoCSerAPI.Ajax.RefOut.Add(3, 5, function (Value: AutoCSer.IHttpRequestReturn) {
        AutoCSer.Skin.Skins['AjaxReturn'].Show(Value);
    });
});