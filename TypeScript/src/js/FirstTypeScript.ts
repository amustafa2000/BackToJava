//Here is a regular javascript class

function Rabbit(name) {
    this.name = name;
    this.getName = function() {
        return this.name;
    }
}

// Below is TypeScript
interface vocalize {
    speakOut();
}
class Person {
    public name:String;
    public age:number;
    private  ssn:string;
    constructor(name:string, age:number){
        this.name = name;
        this.age = age;
    };
    inheritanceFunction(){
        console.log("Inside inheritanceFunction");
    }
    public setSSN(ssn:string){
        if(ssn == '')
            throw "ssn Cannot be empty";
        this.ssn = ssn;
        console.log("SSN set for " + this.name);
    }
}
class Man extends Person implements vocalize{
    constructor(name:string,age:number){
        super(name,age);
    }
    getDescription():string{
        return this.name + " " + this.age;
    }
    anotherFunction(){
        super.inheritanceFunction();
        this.inheritanceFunction();
    }
    inheritanceFunction(){
        console.log("Inheritance in Action Inside inheritanceFunction");
    }
    functionWithReturn(input:string,secondInput:string):string{
        return "returning string: " + input + " "+ secondInput;
    }
    speakOut(){
        console.log("Speaking out");
    }
}
var ahmedPerson = new Person("Ahmed Person", 24);
ahmedPerson.inheritanceFunction();
var ahmed = new Man("Ahmed", 41);
ahmed.anotherFunction();
ahmed.inheritanceFunction();
try{
    ahmed.setSSN('');
}catch (ex) {
    console.log(ex);
}
ahmed.setSSN('MySSN');
var xxx = ahmed.functionWithReturn("One", "Two");
console.log(xxx);
// Test of vocalize
var myVocalizeTest:vocalize = new Man("can vocalize", 3);
myVocalizeTest.speakOut();
var myRabbit = new Rabbit("Good Rabbit");
var myRabbitName = myRabbit.getName();
console.log(myRabbitName);
