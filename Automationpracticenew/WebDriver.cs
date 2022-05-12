using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Automationpracticenew
{
    internal class WebDriver
    {
        public static IWebDriver Driver { get; set; }

        internal void SelectDropdown()
        {
            
            var reg_state = Driver.FindElement(By.Id("id_state"));
            var selectElement = new SelectElement(reg_state);
            selectElement.SelectByValue("1");

            var reg_country = Driver.FindElement(By.Id("id_country"));
            var selectcountry = new SelectElement(reg_country);
            selectcountry.SelectByValue("21");

        }
    }
}
