"use strict";
exports.__esModule = true;
exports.Customer = void 0;
var Customer = /** @class */ (function () {
    function Customer(_firstName, _lastname) {
        this._firstName = _firstName;
        this._lastname = _lastname;
    }
    Object.defineProperty(Customer.prototype, "FirstName", {
        get: function () {
            return this._firstName;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Customer.prototype, "LastName", {
        get: function () {
            return this._lastname;
        },
        enumerable: false,
        configurable: true
    });
    return Customer;
}());
exports.Customer = Customer;
