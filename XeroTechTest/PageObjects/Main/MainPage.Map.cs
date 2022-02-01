using OpenQA.Selenium;
using XeroTechTest.PageObjects.Base;

namespace XeroTechTest.PageObjects.Main
{
    public partial class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement LoginButton => _driver.FindElement(By.XPath("//a[contains(text(), 'Log in')]")); 
    }
}
