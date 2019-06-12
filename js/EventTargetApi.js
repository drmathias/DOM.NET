'use strict';

window.eventTargetApi = {
    addEventListener: function (dotnetEventHandlerApi, eventName, actionCode, useCapture, once, passive) {
        window.addEventListener(eventName, () => passFunction(dotnetEventHandlerApi, actionCode), {
            'capture': useCapture,
            'once': once,
            'passive': passive
        });
    },
    removeEventListener: function (dotnetEventHandlerApi, eventName, actionCode, useCapture) {
        window.removeEventListener(eventName, () => passFunction(dotnetEventHandlerApi, actionCode), {
            'capture': useCapture,
            'once': once,
            'passive': passive
        });
    }
};

let passFunction = function (dotnetEventHandlerApi, actionCode) {
    dotnetEventHandlerApi.invokeMethod('Invoke', actionCode);
};