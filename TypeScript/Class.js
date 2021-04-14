var Person = /** @class */ (function () {
    function Person(message) {
        this.name = message;
    }
    Person.prototype.greet = function () { return "Hello" + this.name; };
    return Person;
}());
var greet = new Person("World");
console.log(greet);
