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

        public By WelcomeBannerBy => By.XPath("//img[@data-automationid='welcomeBanner-excluded-img']");
        public IWebElement WelcomeBanner => _driver.FindElement(WelcomeBannerBy);
        public By UserIconButtonBy => By.XPath("//button[@data-automationid='xnav-addon-user-iconbutton']");
        public IWebElement UserIconButton => _driver.FindElement(UserIconButtonBy);

        #region Accounting
        public By AccountingNavButtonBy => By.XPath("//button[@data-name='navigation-menu/accounting']");
        public IWebElement AccountingNavButton => _driver.FindElement(AccountingNavButtonBy);
        public By BankAccountsOptionBy => By.XPath("//a[@data-name='navigation-menu/accounting/bank-accounts']");
        public IWebElement BankAccountsOption => _driver.FindElement(BankAccountsOptionBy);
        public IReadOnlyCollection<IWebElement> LinkedBankAccounts => _driver.FindElements(By.XPath("//div[@class='xdash-WidgetHeader__widget-header___tj-gn']/header"));
        #endregion
    }
}
