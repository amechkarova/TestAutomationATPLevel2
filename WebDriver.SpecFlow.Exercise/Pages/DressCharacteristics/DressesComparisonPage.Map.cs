using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver.SpecFlow.Exercise.Pages.DressCharacteristics
{
    public partial class DressesComparisonPage
    {
        public ReadOnlyCollection<IWebElement> DressesToCompare => Driver.FindElements(By.XPath("//td[contains(@class, 'compare_extra_information')]/following-sibling::td"));
        public ReadOnlyCollection<IWebElement> DressesCharacteristics => Driver.FindElements(By.XPath("//td[contains(@class, 'feature-name')]/following-sibling::td"));
        public ReadOnlyCollection<IWebElement> Prices => Driver.FindElements(By.XPath("//div[contains(@class, 'prices-container')]//span[@class='price product-price']"));
        public ReadOnlyCollection<IWebElement> Names => Driver.FindElements(By.XPath("//a[contains(@class, 'product-name')]"));
       
    }
}
