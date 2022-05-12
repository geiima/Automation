using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationpracticenew
{
    internal class HomePage : WebDriver
    {
        IWebElement signin_btn = Driver.FindElement(By.ClassName("login"));
        

        public void GoToSigninPage()
        {
            signin_btn.Click();
        }

      
    }
}
