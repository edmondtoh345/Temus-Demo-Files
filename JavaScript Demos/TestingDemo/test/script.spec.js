const { SayHello, SayWelcome, Factorial, GetData } = require('../script');
const assert = require('chai').assert;
const expect = require('chai').expect;

describe('Basic Test Suite', () => {
    it('Sayhello should return hello', () => {
        let result = SayHello();
        assert.equal(result, 'Hello');
    });

    it('SayWelcome should return welcome message with username', () => {
        let result = SayWelcome('John');
        assert.equal(result, 'Welcome John');
    });

    it('Factorial should return factorial of given number', () => {
        let result = Factorial(5);
        assert.equal(result, 120);
    });

    it('Factorial should return number', () => {
        // assert.equal(typeof(Factorial(5)), 'number');
        // assert.typeOf(Factorial(5), 'number');
        let result = Factorial(5);
        expect(result).to.be.a('number');
    });

    it('Object should have name property', () => {
        let result = GetData();
        expect(result).to.have.property('name');
    })


});