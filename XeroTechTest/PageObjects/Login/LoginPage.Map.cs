using OpenQA.Selenium;
using XeroTechTest.PageObjects.Base;

namespace XeroTechTest.PageObjects.Login
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement LoginHeader => _driver.FindElement(By.XPath("//h2[contains(text(), 'Log in to Xero')]"));
        public IWebElement EmailField => _driver.FindElement(By.Id("xl-form-email"));
        public IWebElement PasswordField => _driver.FindElement(By.Id("xl-form-password"));
        public IWebElement LoginButton => _driver.FindElement(By.Id("xl-form-submit"));
    }
}
