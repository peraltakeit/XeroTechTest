using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SELENIUM_EXTRAS = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace XeroTechTest.Helpers
{
    public class WaitHelper
    {
        private WebDriverWait _waitHelper;
        private IWebDriver _driver;

        public WaitHelper(IWebDriver driver)
        {
            _waitHelper = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _driver = driver;
        }

        public void WaitForElementClickable(By locator)
        {
            _waitHelper.Until(SELENIUM_EXTRAS.ElementToBeClickable(locator));
        }

        public void WaitForElementClickable(IWebElement element)
        {
            _waitHelper.Until(SELENIUM_EXTRAS.ElementToBeClickable(element));
        }

        public void WaitForElementExists(By locator)
        {
            _waitHelper.Until(SELENIUM_EXTRAS.ElementExists(locator));
        }

        public void WaitForElementVisible(By locator)
        {
            _waitHelper.Until(SELENIUM_EXTRAS.ElementIsVisible(locator));
        }

        public void WaitForElementSelected(IWebElement element)
        {
            _waitHelper.Until(SELENIUM_EXTRAS.ElementToBeSelected(element));
        }

        public void WaitForElementSelected(By locator)
        {
            _waitHelper.Until(SELENIUM_EXTRAS.ElementToBeSelected(locator));
        }

        public void WaitUntilUrlContains(string fraction)
        {
            _waitHelper.Until(SELENIUM_EXTRAS.UrlContains(fraction));
        }

        public void waitForPageLoadComplete()
        {
            _waitHelper.Until(_driver => ((IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
