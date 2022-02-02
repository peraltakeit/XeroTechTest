using OpenQA.Selenium;
using System.Collections.Generic;
using XeroTechTest.Helpers;
using XeroTechTest.PageObjects.Base;

namespace XeroTechTest.PageObjects.Dashboard
{
    public partial class DashboardPage : BasePage
    {
        WaitHelper _waitHelper;

        public DashboardPage(IWebDriver driver) : base(driver)
        {
            _waitHelper = new WaitHelper(driver);
        }

        public By UserIconButtonBy = By.XPath("//button[@data-automationid='xnav-addon-user-iconbutton']");
        public IWebElement UserIconButton => _driver.FindElement(UserIconButtonBy);

        #region Accounting
        public IWebElement AccountingNavButton => _driver.FindElement(By.XPath("//button[@data-name='navigation-menu/accounting']"));
        public IWebElement BankAccountsOption => _driver.FindElement(By.XPath("//a[@data-name='navigation-menu/accounting/bank-accounts']"));
        public IReadOnlyCollection<IWebElement> LinkedBankAccounts => _driver.FindElements(By.XPath("//div[@class='xdash-WidgetHeader__widget-header___tj-gn']/header"));
        #endregion
    }
}
