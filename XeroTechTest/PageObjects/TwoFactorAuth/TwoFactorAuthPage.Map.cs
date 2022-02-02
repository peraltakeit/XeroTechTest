using OpenQA.Selenium;
using XeroTechTest.Helpers;
using XeroTechTest.PageObjects.Base;

namespace XeroTechTest.PageObjects.TwoFactorAuth
{
    public partial class TwoFactorAuthPage : BasePage
    {
        WaitHelper _waitHelper;

        public TwoFactorAuthPage(IWebDriver driver) : base(driver)
        {
            _waitHelper = new WaitHelper(driver);
        }

        public By BackupMethodBy => By.XPath("//button[@data-automationid='auth-authsetupqa']");
        public IWebElement BackupMethodButton => _driver.FindElement(BackupMethodBy);
        public By SecurityQuestionsButtonBy => By.XPath("//button[@data-automationid='auth-authwithsecurityquestionsbutton']");
        public IWebElement SecurityQuestionsButton => _driver.FindElement(SecurityQuestionsButtonBy);
        public By FirstQuestionBy => By.XPath("//div[label[@data-automationid='auth-firstanswer--label']]");
        public IWebElement FirstSecurityQuestion => _driver.FindElement(FirstQuestionBy);
        public By FirstFieldBy => By.XPath("//input[@data-automationid='auth-firstanswer--input']");
        public IWebElement FirstSecurityQuestionField => _driver.FindElement(FirstFieldBy);
        public By SecondQuestionBy => By.XPath("//div[label[@data-automationid='auth-secondanswer--label']]");
        public IWebElement SecondSecurityQuestion => _driver.FindElement(SecondQuestionBy);
        public By SecondFieldBy => By.XPath("//input[@data-automationid='auth-secondanswer--input']");
        public IWebElement SecondSecurityQuestionField => _driver.FindElement(SecondFieldBy);
        public IWebElement ConfirmButton => _driver.FindElement(By.XPath("//button[@data-automationid='auth-submitanswersbutton']"));
    }
}
