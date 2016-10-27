var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
/**
 * Created by svadmin on 10/27/2016.
 */
var Person = (function () {
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }
    ;
    Person.prototype.parentFunction = function () {
        console.log("Inside parentFunction");
    };
    return Person;
}());
var Man = (function (_super) {
    __extends(Man, _super);
    function Man(name, age) {
        _super.call(this, name, age);
    }
    Man.prototype.getDescription = function () {
        return this.name + " " + this.age;
    };
    Man.prototype.anotherFunction = function () {
        console.log("No Return");
        _super.prototype.parentFunction.call(this);
    };
    return Man;
}(Person));
var ahmed = new Man("Ahmed", 41);
console.log(ahmed.getDescription());
ahmed.anotherFunction();
//# sourceMappingURL=FirstTypeScript.js.map