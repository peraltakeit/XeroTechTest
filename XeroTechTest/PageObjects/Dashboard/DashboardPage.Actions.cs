namespace XeroTechTest.PageObjects.Dashboard
{
    public partial class DashboardPage
    {
        public void ClickBankAccountsOption()
        {
            _waitHelper.WaitForElementClickable(BankAccountsOptionBy);
            BankAccountsOption.Click();
        }

        public bool UserIconButtonIsDisplayed()
        {
            _waitHelper.WaitForElementVisible(UserIconButtonBy);
            return UserIconButton.Displayed;
        }

        public void ClickAccountingButton()
        {
            _waitHelper.WaitForElementClickable(AccountingNavButtonBy);
            AccountingNavButton.Click();
        }

        public bool WelcomeBannerIsDisplayed()
        {
            _waitHelper.WaitForElementVisible(WelcomeBannerBy);
            return WelcomeBanner.Displayed;
        }
    }
}
