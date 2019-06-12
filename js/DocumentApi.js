'use strict';

let elementIdentityKey = 0;
let elementReferences = {};

window.documentApi = {
    getElementById: function (id) {
        const element = document.getElementById(id);
        if (elementAlreadyExists(element)) {
            return getElementKey(element);
        }
        return AddNewElementReference(element);
    }
};

window.elementApi = {
    getId: function (elementKey) {
        return elementReferences[elementKey].id;
    },
    setId: function (elementKey, id) {
        elementReferences[elementKey].id = id;
    },
    scrollIntoView: function (elementKey) {
        elementReferences[elementKey].scrollIntoView();
    },
    dispose: function (elementKey) {
        elementReferences[elementKey] = null;
    }
};

function AddNewElementReference(element) {
    elementReferences[++elementIdentityKey] = element;
    return elementIdentityKey;
}

function elementAlreadyExists(element) {
    return Object.values(elementReferences).includes(element);
}

function getElementKey(element) {
    return getKeyByValue(elementReferences, element);
}

function getKeyByValue(object, value) {
    return Object.keys(object).find(key => object[key] === value);
}