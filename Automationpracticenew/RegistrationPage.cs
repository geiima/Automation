using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationpracticenew
{
    internal class RegistrationPage : WebDriver 
    {
        IWebElement reg_first_name_txt = Driver.FindElement(By.Id("customer_firstname"));
        IWebElement reg_last_name_txt = Driver.FindElement(By.Id("customer_lastname"));
        IWebElement reg_password_txt = Driver.FindElement(By.Id("passwd"));
        IWebElement reg_address_txt = Driver.FindElement(By.Id("address1"));
        IWebElement reg_city_txt = Driver.FindElement(By.Id("city"));
        IWebElement reg_post_code_txt = Driver.FindElement(By.Id("postcode"));
        IWebElement reg_mobile_phone_txt = Driver.FindElement(By.Id("phone_mobile"));
        

        public void FillFormAndRegister(string reg_first_name, string reg_last_name, string reg_password, string reg_address, string reg_city, string reg_post_code, string reg_mobile_phone)
        {
            reg_first_name_txt.SendKeys(reg_first_name);
            reg_last_name_txt.SendKeys(reg_last_name);
            reg_password_txt.SendKeys(reg_password);
            reg_address_txt.SendKeys(reg_address);
            reg_city_txt.SendKeys(reg_city);
            reg_post_code_txt.SendKeys(reg_post_code);
            reg_mobile_phone_txt.SendKeys(reg_mobile_phone);
            
        }
    }
}
