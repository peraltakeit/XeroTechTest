namespace XeroTechTest.PageObjects.Login
{
    public partial class LoginPage
    {
        public void FillInEmailField(string email) => EmailField.SendKeys(email);

        public void FillInPasswordField(string password) => PasswordField.SendKeys(password);

        public void ClickLoginButton() => LoginButton.Click();

        public bool LoginHeaderIsDisplayed()
        {
            return LoginHeader.Displayed;
        }
    }
}
