//Here is a regular javascript class
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
function Rabbit(name) {
    this.name = name;
    this.getName = function () {
        return this.name;
    };
}
var Person = (function () {
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }
    ;
    Person.prototype.inheritanceFunction = function () {
        console.log("Inside inheritanceFunction");
    };
    Person.prototype.setSSN = function (ssn) {
        if (ssn == '')
            throw "ssn Cannot be empty";
        this.ssn = ssn;
        console.log("SSN set for " + this.name);
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
        _super.prototype.inheritanceFunction.call(this);
        this.inheritanceFunction();
    };
    Man.prototype.inheritanceFunction = function () {
        console.log("Inheritance in Action Inside inheritanceFunction");
    };
    Man.prototype.functionWithReturn = function (input, secondInput) {
        return "returning string: " + input + " " + secondInput;
    };
    Man.prototype.speakOut = function () {
        console.log("Speaking out");
    };
    return Man;
}(Person));
var ahmedPerson = new Person("Ahmed Person", 24);
ahmedPerson.inheritanceFunction();
var ahmed = new Man("Ahmed", 41);
ahmed.anotherFunction();
ahmed.inheritanceFunction();
try {
    ahmed.setSSN('');
}
catch (ex) {
    console.log(ex);
}
ahmed.setSSN('MySSN');
var xxx = ahmed.functionWithReturn("One", "Two");
console.log(xxx);
// Test of vocalize
var myVocalizeTest = new Man("can vocalize", 3);
myVocalizeTest.speakOut();
var myRabbit = new Rabbit("Good Rabbit");
var myRabbitName = myRabbit.getName();
console.log(myRabbitName);
//# sourceMappingURL=FirstTypeScript.js.map