import * as cypress from "cypress";

describe('Testing Contact Manager App', () => {
    it('Register user should success', () => {
        cy.visit('http://localhost:4200/register')
        cy.get('#fname').type('James');
        cy.get('#lname').type('Cameron');
        cy.get('#email').type('james@gmail.com');
        cy.get('#password').type('123456');
        cy.get('#city').type('New Delhi');
        cy.get('#age').type('40');
        cy.get('#btn-register').click();
        cy.wait(2000);
        cy.get('.mat-simple-snack-bar-content').should('have.text', 'User registered successfully');
    });
    it('Register user existing email should fail', () => {
        cy.visit('http://localhost:4200/register')
        cy.get('#fname').type('James');
        cy.get('#lname').type('Cameron');
        cy.get('#email').type('james@gmail.com');
        cy.get('#password').type('123456');
        cy.get('#city').type('New Delhi');
        cy.get('#age').type('40');
        cy.get('#btn-register').click();
        cy.wait(2000);
        cy.get('.mat-simple-snack-bar-content').should('have.text', 'User with email address already exists');
    });
});

// describe('template spec', () => {
//     it('passes', () => {
//       cy.visit('https://example.cypress.io')
//     })
//   })