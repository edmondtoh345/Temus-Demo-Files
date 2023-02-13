var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
console.log('Hello World');
var username = 'Peter';
var age;
age = 20;
console.log("".concat(username, " is ").concat(age, " years old"));
// Method 1. Declaring array
var fruits = ['Apple', 'Mango'];
console.log(fruits);
// Method 2. Declaring array
var countries = ['Singapore', 'China', 'India'];
console.log(countries);
var var1; //Any datatype for accepting any type of value
function SayHello(username) {
    return "Hello ".concat(username);
}
console.log(SayHello('John'));
function Display() {
    console.log('Hi');
}
Display();
function Age(age) {
    console.log("Your age is ".concat(age));
}
Age(25);
Age('Twenty Five');
var Person = /** @class */ (function () {
    function Person() {
    }
    Person.prototype.Show = function () {
        console.log('This is show method');
    };
    return Person;
}());
var Student = /** @class */ (function (_super) {
    __extends(Student, _super);
    function Student() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Student.prototype.Display = function () {
        console.log('This is display method');
    };
    return Student;
}(Person));
var obj = new Student();
obj.Display();
obj.Show();
var Calculator = /** @class */ (function () {
    function Calculator() {
    }
    Calculator.prototype.Sum = function (a, b) {
        console.log(a + b);
    };
    Calculator.prototype.Subtract = function (a, b) {
        console.log(a - b);
    };
    return Calculator;
}());
var calc = new Calculator();
calc.Sum(10, 20);
