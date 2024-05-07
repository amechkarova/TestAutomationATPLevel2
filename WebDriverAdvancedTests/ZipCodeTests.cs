using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V120.SystemInfo;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
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
            //_driver = new ChromeDriver();
            //_driver.Manage().Window.Maximize();
            var browserOptions = new ChromeOptions();
            browserOptions.PlatformName = "Windows 11";
            browserOptions.BrowserVersion = "latest";
            var sauceOptions = new Dictionary<string, object>();
            browserOptions.AddAdditionalOption("sauce:options", sauceOptions);
            sauceOptions.Add("username", "oauth-aneliya.mechkarova-24cc8");
            sauceOptions.Add("accessKey", "4673d28e-799a-4065-836b-75ea4cf4edf6");
            sauceOptions.Add("build", "selenium-build-VMBLB");
            sauceOptions.Add("name", "ZipCodeTests");
            
            var uri = new Uri("https://ondemand.eu-central-1.saucelabs.com:443/wd/hub");
            _driver = new RemoteWebDriver(uri, browserOptions);
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