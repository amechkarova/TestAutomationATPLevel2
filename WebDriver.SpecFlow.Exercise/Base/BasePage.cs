using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver.SpecFlow.Exercise.Base
{
    public class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait DriverWait;
        protected string DomainUrl = "http://www.automationpractice.pl/index.php";

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            DriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            Driver.Url = DomainUrl;
        }

        virtual public void NavigateTo()
        {
                Driver.Navigate().GoToUrl(string.Concat(Driver.Url));    
        }

        public void WaitForAjax()
        {
            var js = (IJavaScriptExecutor)Driver;
            DriverWait.Until(wd => js.ExecuteScript("return jQuery.active").ToString() == "0");
        }

        public void WaitUntilPageLoadsCompletely()
        {
            var js = (IJavaScriptExecutor)Driver;
            DriverWait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
