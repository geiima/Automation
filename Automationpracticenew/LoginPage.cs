using OpenQA.Selenium;


namespace Automationpracticenew
{
    internal class LoginPage : WebDriver
    {
        IWebElement email_txt = Driver.FindElement(By.Id("email"));
        IWebElement password_txt = Driver.FindElement(By.Id("passwd"));
        IWebElement login_btn = Driver.FindElement(By.CssSelector("#SubmitLogin > span"));

        public void EnterCredentialsAndLogin(string email, string password)
        {
            email_txt.SendKeys(email);
            password_txt.SendKeys(password);
            login_btn.Click();
        }
    }
}
