let dotnetBlazorWindowApi;

window.subscribeToEvents = function (blazorWindowApi) {
    dotnetBlazorWindowApi = blazorWindowApi;
};

window.getFullScreen = function () {
    return window.fullScreen;
};

window.getLength = function () {
    return window.length;
};

window.getInnerWidth = function () {
    return window.innerWidth;
};

window.getInnerHeight = function () {
    return window.innerHeight;
};

window.getName = function () {
    return window.name;
};

window.setName = function () {
    window.name = name;
};

window.getScreenX = function () {
    return window.screenX;
};

window.getScrollY = function () {
    return window.screenY;
};

window.getScrollX = function () {
    return window.scrollX;
};

window.getScrollY = function () {
    return window.scrollY;
};

window.getStatus = function () {
    return window.status;
};

window.setStatus = function (status) {
    window.status = status;
};

window.onscroll = function () {
    dotnetBlazorWindowApi.invokeMethod('OnScroll', window.scrollX, window.scrollY);
};