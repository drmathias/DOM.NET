'use strict';

let dotnetBlazorWindowApi;

window.windowApi = {
    getFullScreen: function () {
        return window.fullScreen;
    },
    getLength: function () {
        return window.length;
    },
    getInnerWidth: function () {
        return window.innerWidth;
    },
    getInnerHeight: function () {
        return window.innerHeight;
    },
    getName: function () {
        return window.name;
    },
    setName: function () {
        window.name = name;
    },
    getScreenX: function () {
        return window.screenX;
    },
    getScreenY: function () {
        return window.screenY;
    },
    getScrollX: function () {
        return window.scrollX;
    },
    getScrollY: function () {
        return window.scrollY;
    },
    getStatus: function () {
        return window.status;
    },
    setStatus: function (status) {
        window.status = status;
    },
    subscribe: function (blazorWindowApi) {
        dotnetBlazorWindowApi = blazorWindowApi;
    },
    alert: function (message) {
        window.alert(message);
    },
    blur: function () {
        window.blur();
    }
};

window.onscroll = function () {
    dotnetBlazorWindowApi.invokeMethod('OnScroll', window.scrollX, window.scrollY);
};