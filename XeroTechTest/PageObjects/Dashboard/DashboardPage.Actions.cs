namespace XeroTechTest.PageObjects.Dashboard
{
    public partial class DashboardPage
    {
        public void ClickAccountingButton() => AccountingNavButton.Click();

        public void ClickBankAccountsOption() => BankAccountsOption.Click();

        public bool UserIconButtonIsDisplayed()
        {
            _waitHelper.WaitForElementVisible(UserIconButtonBy);
            return UserIconButton.Displayed;
        }
    }
}
