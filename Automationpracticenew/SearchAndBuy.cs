using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationpracticenew
{
    internal class SearchAndBuy : WebDriver
    {
        IWebElement search_item_txt = Driver.FindElement(By.Id("search_query_top"));
        
        

        public void EnterItemAndFind(string search_item)
        {
            search_item_txt.SendKeys(search_item);
            
        }


       

    }
}
