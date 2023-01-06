describe('Login as Committee Member', () => {
    beforeEach (() => {
      cy.visit('https://orisdev.research.unc.edu/irb_maint/index.cfm');
      //cy.get('title')
        //  .invoke('text')
          //.should('equal', '\nIRB \n') 
      cy.get('input#username.long')
          .type('mhannah1').should('have.value', 'mhannah1')  
      cy.get('input#password.long')
          .type('Lordoflords!{Enter}')
 });



 describe('Create NHSR',  () => {
    it('Create NHSR', () => {
        cy.get('#nav > :nth-child(2) > a').click()
        cy.get('#nav > :nth-child(2) > a').click()
        cy.get('#dashboard').should("be.visible")
        cy.get('[style="padding: 10px 10px 5px 10px;"]').should("be.visible")
        cy.get(':nth-child(2) > .wizardLinks1')
        .click()
        cy.get('#wizard1').should("be.visible")
        cy.get('#btn1').click()
       // cy.wait(8000)

    //1. GENERAL INFORMATION SCREEN

        cy.get('#q_29_3').should("be.visible")
        .type('My NHSR Cypress Test')//.should('have.value', 'My NHSR Regression Test') 
       
        cy.get('#cke_q_29_554').should("be.visible")
        .type('My NHSR Cypress Test')//.should('have.value', 'My NHSR Regression Test') 
        
        cy.get('[qid="q_1855"] > td.copy').should("be.visible")
        cy.get('[inputvalue="0"] > #q_29_1855').click()
        cy.get('[name="submit0"]').should("be.visible")
        cy.get('[name="submit1"]').should("be.visible")
        cy.get('[name="submit1"]').click()

    //2. PROJECT PERSONNEL SCREEN

            //PROJECT PERSONNEL WIZARD MODAL (SEARCH PESRONNEL BY RAMSES NUMBER)
        cy.get('#modalPopup').should("be.visible")
        cy.get('#first_name').should("be.visible")
        cy.get('#last_name').should("be.visible")
        cy.get('#pid').should("be.visible")
        cy.get(':nth-child(3) > .tablemainsub > tbody > [align="center"] > .copy > .seachSubmit').should("be.visible")
        cy.get(':nth-child(3) > .tablemainsub > tbody > [align="center"] > .copy > .button').should("be.visible")
        cy.get('#ramses_number').should("be.visible")
        cy.get(':nth-child(4) > .tablemainsub > tbody > [align="center"] > .copy > .seachSubmit').should("be.visible")
        cy.get(':nth-child(4) > .tablemainsub > tbody > [align="center"] > .copy > .seachSubmit').should("be.visible")
        cy.get('[style="width: 100%; text-align: center; margin-top: 10px;"] > .button').click()

            //PROJECT PERSONNEL QUESTIONS
        cy.get('[qid="h_1895"] > [width="99%"]').should("be.visible")
        cy.get('[inputvalue="1"] > #q_2_1895').should("be.visible")
        cy.get('[inputvalue="0"] > #q_2_1895').should("be.visible")
        cy.get('[inputvalue="0"] > #q_2_1895').click()

        cy.get('[qid="h_4"] > [width="99%"]').should("be.visible")
        cy.contains('Click here to add personnel').should("be.visible")
        //cy.get('[onclick="eformCollection('319959','4','2',-1,'0');"]')
        cy.get('#Collection4AdditionalButton > a').should("be.visible")
        cy.contains('Click here to add personnel').click()

            //PROJECT PERSONNEL LOOKUP/POPUP 
        cy.get('#eformDivCollection').should("be.visible")
        cy.get('[qid="q_7"] > .copy > #q_2_7').should("be.visible")
        cy.get('[qid="q_6"] > .copy > #q_2_6').should("be.visible")
        cy.get('[qid="q_10"] > .copy > #q_2_10').should("be.visible")
        cy.get('[qid="q_11"] > .copy > #q_2_11').should("be.visible")
        cy.get('[qid="q_14"] > .copy > #q_2_14').should("be.visible")
        cy.get('[qid="q_9"] > .copy > #q_2_9').should("be.visible")
        cy.get('[qid="q_2142"] > .copy > #q_2_2142').should("be.visible")
        cy.get('[qid="q_7"] > .copy > #q_2_7').click()
        
        cy.contains('First Name:').type('marcus')
        
        
       
       // cy.get('EformLKU').should("be.visible") 
        //cy.get('personnel_results').should("be.visible") 

          
       // cy.visit('https://orisdev.research.unc.edu/irb_maint/eform_lku.cfm?&lku=personnel&ref=eform&que=4');
       // cy.get(':nth-child(2) > .searchresults').should("be.visible")
       // cy.get('#pid').should("be.visible")
        //cy.get('#first_name').should("be.visible")
        //cy.get('#last_name').should("be.visible")
        //cy.get('[name="submit"]').should("be.visible")
        //cy.get('[name="submit2"]').should("be.visible")






       /* cy.get('[qid="h_29"] > [width="99%"]').should("be.visible")
        cy.get('[qid="q_29"] > [style="display: table-cell; padding: 5px 0px 10px 0px;"]').should("be.visible")
        */





         });
    });
});