using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using XeroTechTest.PageObjects.Dashboard;
using XeroTechTest.PageObjects.Login;
using XeroTechTest.PageObjects.TwoFactorAuth;
using XeroTechTest.Steps.Base;

namespace XeroTechTest.Steps.Login
{
    [Binding]
    public class LoginSteps : BaseSteps
    {
        public LoginSteps(IWebDriver driver, IObjectContainer objectContainer, FeatureContext featureContext, ScenarioContext scenarioContext) : base(driver, objectContainer, scenarioContext, featureContext)
        {

        }

        [Given(@"I am in the login page")]
        public void GivenIAmInTheLoginPage()
        {
            var loginPage = new LoginPage(_driver);
            Assert.IsTrue(loginPage.LoginHeaderIsDisplayed(), "You are not in the login page.");
        }
        
        [When(@"I enter ""(.*)"" into the email address field")]
        public void WhenIEnterIntoTheEmailAddressField(string email)
        {
            var loginPage = new LoginPage(_driver);
            loginPage.FillInEmailField(email);
        }
        
        [When(@"I enter ""(.*)"" into the password field")]
        public void WhenIEnterIntoThePasswordField(string password)
        {
            var loginPage = new LoginPage(_driver);
            loginPage.FillInPasswordField(password);
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.ClickLoginButton();
        }
        
        [When(@"I click the Use backup method instead link")]
        public void WhenIClickTheUseBackupMethodInsteadLink()
        {
            var twoFactorPage = new TwoFactorAuthPage(_driver);
            twoFactorPage.ClickBackupMethodButton();
        }
        
        [When(@"I click Security questions")]
        public void WhenIClickSecurityQuestions()
        {
            var twoFactorPage = new TwoFactorAuthPage(_driver);
            twoFactorPage.ClickSecurityQuestionsButton();
        }
        
        [When(@"I answer the security questions")]
        public void WhenIAnswerTheSecurityQuestions()
        {
            var twoFactorPage = new TwoFactorAuthPage(_driver);

            List<string> questions = new List<string>();
            questions.Add(twoFactorPage.GetFirstQuestion());
            questions.Add(twoFactorPage.GetSecondQuestion());

            List<string> answers = new List<string>();

            foreach(string question in questions)
            {
                switch (question)
                {
                    case "What is your dream car?":
                        answers.Add("corolla");
                        break;
                    case "What was the name of your first pet?":
                        answers.Add("bones");
                        break;
                    case "What is your most disliked movie?":
                        answers.Add("last airbender");
                        break;
                    default:
                        break;
                }
            }

            twoFactorPage.FillInFirstQuestion(answers[0]);
            twoFactorPage.FillInSecondQuestion(answers[1]);
        }
        
        [When(@"I click the confirm button")]
        public void WhenIClickTheConfirmButton()
        {
            var twoFactorPage = new TwoFactorAuthPage(_driver);
            twoFactorPage.ClickConfirmButton();
        }
        
        [Then(@"I should be taken to my dashboard page")]
        public void ThenIShouldBeTakenToMyDashboardPage()
        {
            var dashboardPage = new DashboardPage(_driver);
            Assert.IsTrue(dashboardPage.UserIconButtonIsDisplayed(), "You haven't logged in successfully.");
        }
    }
}
