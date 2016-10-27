/**
 * Created by svadmin on 10/27/2016.
 */
class Person {
    public name:String;
    public age:number;
    constructor(name:string, age:number){
        this.name = name;
        this.age = age;
    };
    parentFunction(){
        console.log("Inside parentFunction");
    }
}

class  Man extends Person{
    constructor(name:string,age:number){
        super(name,age);
    }
    getDescription():string{
        return this.name + " " + this.age;
    }
    anotherFunction(){
        console.log("No Return");
        super.parentFunction();
    }
}

var ahmed:Man = new Man("Ahmed", 41);
console.log(ahmed.getDescription());
ahmed.anotherFunction();
