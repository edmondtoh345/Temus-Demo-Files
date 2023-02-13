function SayHello() {
    return 'Hello';
}

function SayWelcome(username) {
    return `Welcome ${username}`;
}

function Factorial(num) {
    let fact = 1;
    for (i = 1; i <= num; i++) {
        fact = fact * i;
    }
    return fact;
}

function GetData(){
    return {
        name: 'Peter',
        age: 25,
        email: 'Peter@gmail.com'
    }
}

module.exports = { SayHello, SayWelcome, Factorial, GetData }