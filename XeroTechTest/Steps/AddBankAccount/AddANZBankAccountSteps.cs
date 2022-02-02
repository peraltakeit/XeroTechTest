using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using XeroTechTest.PageObjects.BankAccounts;
using XeroTechTest.PageObjects.Dashboard;
using XeroTechTest.Steps.Base;

namespace XeroTechTest.Steps.AddBankAccount
{
    [Binding]
    public class AddANZBankAccountSteps : BaseSteps
    {
        private string _accountName;

        public AddANZBankAccountSteps(IWebDriver driver, IObjectContainer objectContainer, FeatureContext featureContext, ScenarioContext scenarioContext) 
            : base(driver, objectContainer, scenarioContext, featureContext)
        {

        }

        [Given(@"I click the Accounting navigation button")]
        public void GivenIClickTheAccountingNavigationButton()
        {
            var dashboardPage = new DashboardPage(_driver);
            dashboardPage.ClickAccountingButton();
        }

        [When(@"I click the Bank accounts option")]
        public void WhenIClickTheBankAccountsOption()
        {
            var dashboardPage = new DashboardPage(_driver);
            dashboardPage.ClickBankAccountsOption();
        }

        [When(@"I click on the ANZ \(NZ\) option")]
        public void WhenIClickOnTheANZNZOption()
        {
            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.ClickBankNameANZ();
        }
        
        [When(@"I enter a unique bank account name")]
        public void WhenIEnterAUniqueBankAccountName()
        {
            _accountName = Guid.NewGuid().ToString();
            _accountName.Substring(_accountName.Length - 7); //avoiding the max length allowed in the field
            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.FillInAccountNameField(_accountName);
        }
        
        [When(@"I select the first account type")]
        public void WhenISelectTheFirstAccountType()
        {
            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.ClickAccountTypeDropdown();
            bankAccountPage.ClickAccountTypeFirstOption();
        }

        [When(@"I enter an account number into the account number field")]
        public void WhenIEnterAnAccountNumberIntoTheAccountNumberField()
        {
            var random = new Random();
            string accountNumber = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                accountNumber = String.Concat(accountNumber, random.Next(10).ToString());
            }

            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.FillInAccountNumberField(accountNumber);
        }
        
        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.ClickContinueButton();
        }
        
        [When(@"I click the Ive got a form button")]
        public void WhenIClickTheIveGotAFormButton()
        {
            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.ClickIHaveAFormButton();
        }
        
        [When(@"I click the Ill do it later button")]
        public void WhenIClickTheIllDoItLaterButton()
        {
            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.ClickIllDoItLaterButton();
        }
        
        [When(@"I click the go to dashboard button")]
        public void WhenIClickTheGoToDashboardButton()
        {
            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.ClickGoToDashboardButton();
        }
        
        [Then(@"I should be taken to the bank accounts page")]
        public void ThenIShouldBeTakenToTheBankAccountsPage()
        {
            var bankAccountPage = new BankAccountsPage(_driver);
            Assert.IsTrue(bankAccountPage.AddBankAccountButtonIsDisplayed(), 
                "You are not in the bank account page.");
        }
        
        [Then(@"I click the Add Bank Account button")]
        public void ThenIClickTheAddBankAccountButton()
        {
            var bankAccountPage = new BankAccountsPage(_driver);
            bankAccountPage.ClickAddBankAccountButton();
        }
        
        //[Then(@"I should see my bank account in the list of bank accounts")]
        //public void ThenIShouldSeeMyBankAccountInTheListOfBankAccounts()
        //{
        //    var bankAccountPage = new BankAccountsPage(_driver);
        //    StringAssert.Contains(_accountName, bankAccountPage.GetBankAccountListText(), 
        //        "The expected bank account name is not in the list of bank accounts.");
        //}
        
        [Then(@"I should see my unique bank account name in my dashboard")]
        public void ThenIShouldSeeMyUniqueBankAccountNameInMyDashboard()
        {
            var dashboardPage = new DashboardPage(_driver);
            bool expectedAccountNameExists = false;
            Assert.IsTrue(dashboardPage.WelcomeBannerIsDisplayed(), 
                "You are not in the dashboard page.");

            var accountHeaders = dashboardPage.LinkedBankAccounts;

            foreach(var account in accountHeaders)
            {
                var accountText = account.Text;

                if (accountText.Contains(_accountName))
                {
                    expectedAccountNameExists = true;
                }
            }

            Assert.IsTrue(expectedAccountNameExists, 
                "The expected account name is not in the list of bank accounts in your dashboard");
        }
    }
}
