using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Automationpracticenew
{
    internal class SigninPage : WebDriver
    {

        IWebElement email_txt = Driver.FindElement(By.Id("email_create"));
        IWebElement createaccount_btn = Driver.FindElement(By.CssSelector("#SubmitCreate > span"));

        public void EnterCredentialsAndSignin(string email)
        {
            email_txt.SendKeys(email);
            createaccount_btn.Click();
        }
    }
}
