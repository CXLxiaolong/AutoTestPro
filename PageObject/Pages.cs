using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using MyDriver;

namespace PageObject
{
  public static class Pages
    {
      
        private static readonly WebDriver _driver;

      //  public Pages(WebDriver driver)
       // {
         //   _driver = driver;
        // }

        public static HomePage homepage
        {
            get{

                var Page = new HomePage();
                return Page;          
            }

        }
        




    }
}
