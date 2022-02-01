namespace XeroTechTest.PageObjects.BankAccounts
{
    public partial class BankAccountsPage
    {
        public void ClickAddBankAccountButton() => AddBankAccountButton.Click();
        
        public void ClickBankName(string bankName) => BankName(bankName).Click();

        public void FillInAccountNameField(string accountName) => AccountNameField.SendKeys(accountName);

        public void ClickAccountTypeDropdown() => AccountTypeDropDown.Click();

        public void ClickAccountTypeFirstOption() => AccountTypeFirstOption.Click();

        public void FillInAccountNumberField(string accountNumber) => AccountNumberField.SendKeys(accountNumber);

        public void ClickIHaveAFormButton() => IHaveAFormButton.Click();

        public void ClickIllDoItLaterButton() => IllDoItLaterButton.Click();
         
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
            return BankAccountsList.Text;
        }
    }
}
