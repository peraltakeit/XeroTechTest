using OpenQA.Selenium;
using System.Collections.Generic;
using XeroTechTest.PageObjects.Base;

namespace XeroTechTest.PageObjects.Dashboard
{
    public partial class DashboardPage : BasePage
    {
        public DashboardPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement GetBankFeedsButton => _driver.FindElement(By.XPath("//a[@data-automationid='getBankFeeds']"));

        #region Accounting
        public IWebElement AccountingNavButton => _driver.FindElement(By.XPath("//button[@data-name='navigation-menu/accounting']"));
        public IWebElement BankAccountsOption => _driver.FindElement(By.XPath("//a[@data-name='navigation-menu/accounting/bank-accounts']"));
        public IReadOnlyCollection<IWebElement> LinkedBankAccounts => _driver.FindElements(By.XPath("//div[@class='xdash-WidgetHeader__widget-header___tj-gn']/header"));
        #endregion
    }
}
