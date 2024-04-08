using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V120.SystemInfo;
using OpenQA.Selenium.Internal;
using System.Xml.Linq;
using ZipCodePages;

namespace WebDriverAdvancedTests
{
    [TestClass]
    public class ZipCodeTests
    {
        private IWebDriver _driver;
        [TestInitialize]
        public void TestInit()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }
        [TestCleanup]
        public void TestCleanup() 
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void SearchForATown_When_3LettersAreUsed()
        {
            AdvancedSearchPage advancedSearchPage = new AdvancedSearchPage(_driver);
            advancedSearchPage.EnterCityForSearch("a");
            List<City> cities = advancedSearchPage.GenerateCities();
            //generate links to google maps with the coordinates
            //GenerateGoogleMapsLink(cities, _driver);

        }

        private void GenerateGoogleMapsLink(List<City> cities, IWebDriver driver)
        {
            string baseUrl = "https://www.google.com/maps/search/?api=1&query=";
            string filePath = "C:/googleMaps/";
            foreach (City city in cities)
            {
                driver.Navigate().GoToUrl(baseUrl + city.Coordinates);
                string filename = city.Name + "-" + city.State + "-" + city.ZipCode + ".png";
                TakeFullScreenshot(_driver, filePath + filename);
            }

        }

        public void TakeFullScreenshot(IWebDriver driver, string filename)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(filename);
        }
    }
}