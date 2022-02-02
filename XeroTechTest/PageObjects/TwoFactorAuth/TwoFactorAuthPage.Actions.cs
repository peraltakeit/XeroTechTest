namespace XeroTechTest.PageObjects.TwoFactorAuth
{
    public partial class TwoFactorAuthPage
    {
        public void ClickBackupMethodButton()
        {
            _waitHelper.WaitForElementClickable(BackupMethodBy);
            BackupMethodButton.Click();
        }

        public void ClickSecurityQuestionsButton()
        {
            _waitHelper.WaitForElementClickable(SecurityQuestionsButtonBy);
            SecurityQuestionsButton.Click();
        }
        public void FillInFirstQuestion(string answer)
        {
            _waitHelper.WaitForElementExists(FirstFieldBy);
            FirstSecurityQuestionField.SendKeys(answer);
        }

        public void FillInSecondQuestion(string answer)
        {
            _waitHelper.WaitForElementExists(SecondFieldBy);
            SecondSecurityQuestionField.SendKeys(answer);
        }

        public void ClickConfirmButton() => ConfirmButton.Click();
        public string GetFirstQuestion()
        {
            _waitHelper.WaitForElementVisible(FirstQuestionBy);
            return FirstSecurityQuestion.Text;
        }

        public string GetSecondQuestion()
        {
            _waitHelper.WaitForElementVisible(SecondQuestionBy);
            return SecondSecurityQuestion.Text;
        }
    }
}
