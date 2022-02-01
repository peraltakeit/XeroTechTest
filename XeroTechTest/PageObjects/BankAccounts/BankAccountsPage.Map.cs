using OpenQA.Selenium;
using XeroTechTest.PageObjects.Base;

namespace XeroTechTest.PageObjects.BankAccounts
{
    public partial class BankAccountsPage : BasePage
    {
        public BankAccountsPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement AddBankAccountButton => _driver.FindElement(By.XPath("//a/span[@data-automationid='Add Bank Account-button']"));
        public IWebElement BankName(string bankName) => _driver.FindElement(By.XPath($"//a[contains(text(), {bankName})]"));
        public IWebElement AccountNameField => _driver.FindElement(By.Id("accountname-1025-inputEl"));
        public IWebElement AccountTypeDropDown => _driver.FindElement(By.Id("accounttype-1027-bodyEl"));
        public IWebElement AccountTypeOptions => _driver.FindElement(By.Id("boundlist-1064-listWrap"));
        public IWebElement AccountTypeFirstOption => _driver.FindElement(By.XPath("//div[@id='boundlist-1064-listWrap']/ul/li[1]"));
        public IWebElement AccountNumberField => _driver.FindElement(By.Id("accountnumber-1056-inputEl"));
        public IWebElement ContinueButton => _driver.FindElement(By.XPath("//a[@data-automationid='continueButton']"));
        public IWebElement BankAccountsList => _driver.FindElement(By.XPath("//div[@data-automationid='account-list']"));
        public IWebElement IHaveAFormButton => _driver.FindElement(By.XPath("//a[@data-automationid='connectbank-buttonIHaveAForm']"));
        public IWebElement IllDoItLaterButton => _driver.FindElement(By.XPath("//a[@data-automationid='uploadForm-uploadLaterButton']"));
    }
}
