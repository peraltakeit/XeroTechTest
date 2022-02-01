namespace XeroTechTest.PageObjects.TwoFactorAuth
{
    public partial class TwoFactorAuthPage
    {
        public void ClickBackupMethodButton() => BackupMethodButton.Click();

        public void ClickSecurityQuestionsButton() => SecurityQuestionsButton.Click();

        public void FillInFirstQuestion(string answer) => FirstSecurityQuestionField.SendKeys(answer);

        public void FillInSecondQuestion(string answer) => SecondSecurityQuestionField.SendKeys(answer);

        public void ClickConfirmButton() => ConfirmButton.Click();
        public string GetFirstQuestion()
        {
            return FirstSecurityQuestion.Text;
        }

        public string GetSecondQuestion()
        {
            return SecondSecurityQuestion.Text;
        }
    }
}
