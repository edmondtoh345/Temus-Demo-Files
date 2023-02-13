console.log('Hello World');
let username: string = 'Peter';
let age: number;
age = 20;
console.log(`${username} is ${age} years old`);

// Method 1. Declaring array
let fruits: string[] = ['Apple', 'Mango'];
console.log(fruits);

// Method 2. Declaring array
let countries: Array<string> = ['Singapore', 'China', 'India'];
console.log(countries);

let var1: any; //Any datatype for accepting any type of value

function SayHello(username: string): string {
    return `Hello ${username}`;
}

console.log(SayHello('John'));

function Display(): void {
    console.log('Hi');
}

Display();

function Age(age: number | string): void {
    console.log(`Your age is ${age}`);
}

Age(25);
Age('Twenty Five');

class Person {
    public Show(): void {
        console.log('This is show method');
    }

    public username: string;
}

class Student extends Person {
    public Display(): void {
        console.log('This is display method');
    }
}

let obj = new Student();
obj.Display();
obj.Show();

interface ICalculator {
    Sum(a: number, b: number): void
    Subtract(a: number, b: number): void
}

class Calculator implements ICalculator {
    Sum(a: number, b: number): void {
        console.log(a + b);
    }
    Subtract(a: number, b: number): void {
        console.log(a - b);
    }
}

let calc = new Calculator();
calc.Sum(10, 20);












