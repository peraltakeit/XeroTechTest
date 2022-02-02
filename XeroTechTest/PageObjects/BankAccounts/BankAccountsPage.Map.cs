using OpenQA.Selenium;
using XeroTechTest.Helpers;
using XeroTechTest.PageObjects.Base;

namespace XeroTechTest.PageObjects.BankAccounts
{
    public partial class BankAccountsPage : BasePage
    {
        WaitHelper _waitHelper;

        public BankAccountsPage(IWebDriver driver) : base(driver)
        {
            _waitHelper = new WaitHelper(driver);
        }

        public By AddBankAccountButtonBy => By.XPath("//a/span[@data-automationid='Add Bank Account-button']");
        public IWebElement AddBankAccountButton => _driver.FindElement(AddBankAccountButtonBy);
        public By BankNameANZBy => By.XPath("//a[@data-automationid='popularBank-0']");
        public IWebElement BankNameANZ => _driver.FindElement(BankNameANZBy);
        public By AccountNameFieldBy => By.Id("accountname-1025-inputEl");
        public IWebElement AccountNameField => _driver.FindElement(AccountNameFieldBy);
        public By AccountTypeDropdownBy => By.Id("accounttype-1027-bodyEl");
        public IWebElement AccountTypeDropdown => _driver.FindElement(AccountTypeDropdownBy);
        public By AccountOptionsBy => By.Id("boundlist-1064-listWrap");
        public IWebElement AccountTypeOptions => _driver.FindElement(AccountOptionsBy);
        public By AccountFirstOptionBy => By.XPath("//div[@id='boundlist-1064-listWrap']/ul/li[1]");
        public IWebElement AccountTypeFirstOption => _driver.FindElement(AccountFirstOptionBy);
        public By AccountNumberFieldBy => By.Id("accountnumber-1056-inputEl");
        public IWebElement AccountNumberField => _driver.FindElement(AccountNumberFieldBy);
        public IWebElement ContinueButton => _driver.FindElement(By.XPath("//a[@data-automationid='continueButton']"));
        public By BankAccountsListBy = By.XPath("//div[@data-automationid='account-list']");
        public IWebElement BankAccountsList => _driver.FindElement(BankAccountsListBy);
        public By IHaveAFormBy = By.XPath("//a[@data-automationid='connectbank-buttonIHaveAForm']");
        public IWebElement IHaveAFormButton => _driver.FindElement(IHaveAFormBy);
        public By IllDoItLaterBy => By.XPath("//a[@data-automationid='uploadForm-uploadLaterButton']");
        public IWebElement IllDoItLaterButton => _driver.FindElement(IllDoItLaterBy);
        public By GoToDashboardButtonBy => By.XPath("//a[@data-automationid='uploadFormLater-goToDashboardButton']");
        public IWebElement GoToDashboardButton => _driver.FindElement(GoToDashboardButtonBy);
    }
}
