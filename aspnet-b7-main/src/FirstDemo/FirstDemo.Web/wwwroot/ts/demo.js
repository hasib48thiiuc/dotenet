var message = 'Hello World';
console.log(message);
var x;
x = ["jalaluddin", 10];
console.log(x[0]);
var something = "jalaluddin";
var soemthing2 = 5;
var notSure = 4;
notSure = "maybe a string instead";
notSure = false;
notSure.ifItExists(); // okay, ifItExists might exist at runtime
notSure.toFixed(); // okay, toFixed exists (but the compiler doesn't check)
function warnUser() {
    console.log("This is my warning message");
}
var someValue = "this is a string";
var str = someValue;
var Greeter = /** @class */ (function () {
    function Greeter(message) {
        this.greeting = message;
    }
    Greeter.prototype.greet = function () {
        return "Hello, " + this.greeting;
    };
    return Greeter;
}());
function printLabel(labeledObj) {
    console.log(labeledObj.label);
}
var myObj = { label: "" };
printLabel(myObj);
var Employee = /** @class */ (function () {
    function Employee(code, name) {
        this.empCode = code;
        this.name = name;
    }
    Employee.prototype.getSalary = function (empCode) {
        return 20000;
    };
    return Employee;
}());
var Octopus = /** @class */ (function () {
    function Octopus(name) {
        this.name = name;
        this.numberOfLegs = 8;
    }
    return Octopus;
}());
//# sourceMappingURL=demo.js.map