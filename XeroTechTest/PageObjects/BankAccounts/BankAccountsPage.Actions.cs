namespace XeroTechTest.PageObjects.BankAccounts
{
    public partial class BankAccountsPage
    {
        public bool AddBankAccountButtonIsDisplayed()
        {
            _waitHelper.WaitForElementClickable(AddBankAccountButtonBy);
            return AddBankAccountButton.Displayed;
        }

        public void ClickAddBankAccountButton() => AddBankAccountButton.Click();
        
        public void ClickBankNameANZ()
        {
            _waitHelper.WaitForElementVisible(BankNameANZBy);
            BankNameANZ.Click();
        }

        public void FillInAccountNameField(string accountName)
        {
            _waitHelper.WaitForElementExists(AccountNameFieldBy);
            AccountNameField.SendKeys(accountName);
        }

        public void ClickAccountTypeDropdown() => AccountTypeDropdown.Click();

        public void ClickAccountTypeFirstOption()
        {
            _waitHelper.WaitForElementVisible(AccountOptionsBy);
            AccountTypeFirstOption.Click();
        }

        public void FillInAccountNumberField(string accountNumber)
        {
            _waitHelper.WaitForElementVisible(AccountNumberFieldBy);
            AccountNumberField.SendKeys(accountNumber);
        }

        public void ClickContinueButton() => ContinueButton.Click();

        public void ClickIHaveAFormButton()
        {
            _waitHelper.WaitForElementClickable(IHaveAFormBy);
            IHaveAFormButton.Click();
        }

        public void ClickIllDoItLaterButton()
        {
            _waitHelper.WaitForElementClickable(IllDoItLaterBy);
            IllDoItLaterButton.Click();
        }
         
        public bool AccountTypeOptionsIsDisplayed()
        {
            return AccountTypeOptions.Displayed;
        }

        public bool AccountNumberFieldIsDisplayed()
        {
            return AccountNumberField.Displayed;
        }

        public string GetBankAccountListText()
        {
            _waitHelper.WaitForElementVisible(BankAccountsListBy);
            return BankAccountsList.Text;
        }

        public void ClickGoToDashboardButton()
        {
            _waitHelper.WaitForElementClickable(GoToDashboardButtonBy);
            GoToDashboardButton.Click();
        }
    }
}
