let message: string = 'Hello World';
console.log(message);


let x: [string, number];

x = ["jalaluddin", 10];

console.log(x[0]);

let something: Object = "jalaluddin";
let soemthing2: any = 5;


let notSure: any = 4;
notSure = "maybe a string instead";
notSure = false; 

notSure.ifItExists(); // okay, ifItExists might exist at runtime
notSure.toFixed(); // okay, toFixed exists (but the compiler doesn't check)

function warnUser(): void {
    console.log("This is my warning message");
}

declare function create(o: object | null): void;

let someValue: any = "this is a string";
let str: string = <string>someValue;

class Greeter {
    greeting: string;
    constructor(message: string) {
        this.greeting = message;
    }
    greet() {
        return "Hello, " + this.greeting;
    }
}

function printLabel(labeledObj: { label: string }) {
    console.log(labeledObj.label);
}

let myObj = { label: "" };
printLabel(myObj);


interface IEmployee {
    empCode: number;
    name: string;
    getSalary: (n : number) => number;
}

class Employee implements IEmployee {
    empCode: number;
    name: string;

    constructor(code: number, name: string) {
        this.empCode = code;
        this.name = name;
    }

    getSalary(empCode: number): number {
        return 20000;
    }
}

class Octopus {
    readonly numberOfLegs: number = 8;
    constructor(readonly name: string) { }
}

