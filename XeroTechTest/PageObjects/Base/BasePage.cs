using OpenQA.Selenium;

namespace XeroTechTest.PageObjects.Base
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
