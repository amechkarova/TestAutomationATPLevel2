using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using ZipCodePages;

namespace WebDriverAdvancedTests;

[TestClass]
public class ZipCodeTests
{
    private IWebDriver _driver;
    [TestInitialize]
    public void TestInit()
    {
        //_driver = new ChromeDriver();
        //_driver.Manage().Window.Maximize();
        //var browserOptions = new ChromeOptions();
        //browserOptions.PlatformName = "Windows 11";
        //browserOptions.BrowserVersion = "latest";
        //var sauceOptions = new Dictionary<string, object>();
        //browserOptions.AddAdditionalOption("sauce:options", sauceOptions);
        //sauceOptions.Add("username", "");
        //sauceOptions.Add("accessKey", "");
        //sauceOptions.Add("build", "selenium-build-VMBLB");
        //sauceOptions.Add("name", "ZipCodeTests");

        var driverOptions = new ChromeOptions();
        var runName = GetType().Assembly.GetName().Name;
        var timestamp = $"{DateTime.Now:yyyyMMdd.HHmm}";
        driverOptions.AddAdditionalOption("name", runName);
        driverOptions.AddAdditionalOption("videoName", $"{runName}.{timestamp}.mp4");
        driverOptions.AddAdditionalOption("logName", $"{runName}.{timestamp}.log");
        driverOptions.AddAdditionalOption("enableVNC", true);
        driverOptions.AddAdditionalOption("enableVideo", true);
        driverOptions.AddAdditionalOption("enableLog", true);
        driverOptions.AddAdditionalOption("screenResolution", "1920x1080x24");
        _driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), driverOptions);
        _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);


        //var uri = new Uri("https://ondemand.eu-central-1.saucelabs.com:443/wd/hub");
        //_driver = new RemoteWebDriver(uri, browserOptions);
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
        advancedSearchPage.Open();
        advancedSearchPage.EnterCityForSearch("ala");
        List<City> cities = advancedSearchPage.GenerateCities();
        Assert.IsNotNull(cities);
        //generate links to google maps with the coordinates
        GenerateGoogleMapsLink(cities, _driver);

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