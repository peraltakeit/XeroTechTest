using OpenQA.Selenium;
using XeroTechTest.PageObjects.Base;

namespace XeroTechTest.PageObjects.TwoFactorAuth
{
    public partial class TwoFactorAuthPage : BasePage
    {
        public TwoFactorAuthPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement BackupMethodButton => _driver.FindElement(By.XPath("//button[@data-automationid='auth-authsetupqa']"));
        public IWebElement SecurityQuestionsButton => _driver.FindElement(By.XPath("//button[@data-automationid='auth-authwithsecurityquestionsbutton']"));
        public IWebElement FirstSecurityQuestion => _driver.FindElement(By.XPath("//label[@data-automationid='auth-firstanswer--label']"));
        public IWebElement FirstSecurityQuestionField => _driver.FindElement(By.XPath("//input[@data-automationid='auth-firstanswer--input']"));
        public IWebElement SecondSecurityQuestion => _driver.FindElement(By.XPath("//label[@data-automationid='auth-secondanswer--label']"));
        public IWebElement SecondSecurityQuestionField => _driver.FindElement(By.XPath("//input[@data-automationid='auth-secondanswer--input']"));
        public IWebElement ConfirmButton => _driver.FindElement(By.XPath("//button[@data-automationid='auth-submitanswersbutton']"));
    }
}
