﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using SeleniumExtras.WaitHelpers;
using Newtonsoft.Json.Bson;
namespace ZipCodePages
{
    public class AdvancedSearchPage
    {
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait Wait { get; set; }
        public AdvancedSearchPage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Url = "https://www.zip-codes.com/search.asp?selectTab=3";
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected IWebElement cityField => Driver.FindElement(By.XPath("//table//td[2]//div[@class='element atStart ui-accordion-content ui-corner-bottom ui-helper-reset ui-widget-content ui-accordion-content-active']//input[@aria-label='City']"));
        protected IWebElement findZipCodesBtn => Driver.FindElement(By.XPath("//table//td[2]//div[@class='element atStart ui-accordion-content ui-corner-bottom ui-helper-reset ui-widget-content ui-accordion-content-active']//input[@value='Find ZIP Codes']"));

        protected ReadOnlyCollection<IWebElement> allCities => Driver.FindElements(By.XPath("//table[@id='tblZIP']//td[2]/a"));
        protected ReadOnlyCollection<IWebElement> allZipCodes => Driver.FindElements(By.XPath("//table[@id='tblZIP']//td[1]/a"));
        protected ReadOnlyCollection<IWebElement> allStates => Driver.FindElements(By.XPath("//table[@id='tblZIP']//td[3]/a"));
        protected IWebElement personalDataConsentButton => Driver.FindElement(By.XPath("//div[contains(@class, 'fc-choice-dialog')]//button[contains(@class, 'fc-cta-consent')]"));
        protected ReadOnlyCollection<IWebElement> pages => Driver.FindElements(By.XPath("//div[@class='pages']//a"));

        private void GoToCityDetailedInfo(IWebElement city)
        {
            city.Click();
        }

        private void GoToNextPage(IWebElement page)
        {
            page.Click();
        }

        public void EnterCityForSearch(string city)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'fc-choice-dialog')]//button[contains(@class, 'fc-cta-consent')]")));
            personalDataConsentButton.Click();
            cityField.Clear();
            cityField.SendKeys(city);
            findZipCodesBtn.Click();
        }

        public List<City> GenerateCities()
        {
            List<City> cityList = new List<City>();
            int pageIndex = 0;
            if(pages.Count >= 0)
            {
                do
                { 
                    int i = 0;
                    int searchResultCount = allCities.Count;
                    while (i < searchResultCount)
                    {
                        cityList.Add(new City(allCities[i].Text, allZipCodes[i].Text, allStates[i].Text));
                        GoToCityDetailedInfo(Driver.FindElements(By.XPath("//table[@class='statTable sortableTbl']//td[2]/a"))[i]);
                        CityDetailsPage cityPage = new CityDetailsPage(Driver);
                        cityList[i].Coordinates = cityPage.GetCoordinates();

                        Driver.Navigate().Back();
                        i++;
                    }
                    pageIndex++;
                    if (pages.Count > 0)
                    {
                        GoToNextPage(Driver.FindElements(By.XPath("//div[@class='pages']//a"))[pageIndex]);
                    }
                    
                }
                while (pageIndex < pages.Count);
            }
            return cityList;
        }
    }
}
