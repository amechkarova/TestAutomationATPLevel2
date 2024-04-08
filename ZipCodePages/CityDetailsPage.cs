using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipCodePages
{
    public class CityDetailsPage
    {
        protected IWebDriver Driver { get; set; }
        public CityDetailsPage(IWebDriver driver)
        {
            Driver = driver;
        }
        protected IWebElement coordinates => Driver.FindElement(By.XPath("//div[@id='top']//table//span[text()='Coordinates:']/parent::td/following-sibling::td[1]"));

        public string GetCoordinates()
        {
            return coordinates.Text;
        }
    }
}
