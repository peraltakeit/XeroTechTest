namespace XeroTechTest.PageObjects.Dashboard
{
    public partial class DashboardPage
    {
        public void ClickAccountingButton() => AccountingNavButton.Click();

        public void ClickBankAccountsOption() => BankAccountsOption.Click();

        public bool GetBankFeedsButtonIsDisplayed()
        {
            return GetBankFeedsButton.Displayed;
        }
    }
}
