console.log('Welcome to JavaScript');

var num = 10;
let name = 'John';
const age = 30;

// primitive types
// Number, string, bool, undefined, null

// Object types
// Arrays, Classes
console.log(typeof (age));

// Conditional Constructs
// if...else, switch...case
var x = 2;
if (x % 2 == 0) {
    console.log('Number is even');
} else {
    console.log('Number is Odd');
}

switch (x) {
    case 1: {
        console.log('Sunday');
        break;
    }
    case 2: {
        console.log('Monday')
        break;
    }
    default: {
        console.log('Wrong Options');
        break;
    }
}

// Looping Constructs
// For, While, Do...While

// Arrays
// Declaring an array
let fruits = ['Apple', 'Banana', 'Cherry', 'Mango'];
console.log(fruits);

// Declaring another way of declaring an array
let arr = new Array(5);
arr[0] = 10;
arr[1] = 20;

let countries = [];
countries.push('Singapore');
countries.push('China');

console.log(countries);
console.log(countries.pop());

let students = ['Peter', 'John', 'James', 'Maria'];
console.log(students);
students.splice(2, 1);
console.log(students);

console.log(students.length);
for (var s of students) {
    console.log(s);
}

students.forEach(function (val, i) {
    console.log(`Name ${val} is on ${i} position`);
})

students.map((val, i) => {
    console.log(val);
});

// Objects in JavaScript

let person = {
    firstname: 'Peter',
    lastname: 'Parker',
    age: 30,
    Show: function () {
        console.log(`${this.firstname} ${this.lastname} is ${this.age} years old`)
    }
}

person.Show();
console.log(person.age);

// Array of objects
let persons = [
    {
        firstname: 'Peter',
        lastname: 'Parker',
        age: 25
    },
    {
        firstname: 'Tony',
        lastname: 'Stark',
        age: 35
    },
    {
        firstname: 'Steven',
        lastname: 'Strange',
        age: 40
    }
];

for (var p of persons) {
    console.log(p.firstname);
}

// function SayHello(){
//     console.log('Welcome to JavScript')
// }

// const SayHello = () => {
//     console.log('Welcome');
// }

const SayHello = (name) =>{
    console.log(`Hello ${name}`);
}

SayHello('John');






