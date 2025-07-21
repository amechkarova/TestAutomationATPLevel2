using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverAdvancedTests;

[TestClass]
public class ConfirmationBoxesExample
{
    private IWebDriver _driver;

    [TestInitialize]
    public void TestInit()
    {
        _driver = new ChromeDriver();
        _driver.Navigate().GoToUrl("https://demoqa.com/alerts");
        _driver.Manage().Window.Maximize();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        _driver.Quit();
    }
    [TestMethod]
    public void Accept_ConfirmationBox()
    {
        IWebElement confirmBoxButton = _driver.FindElement(By.Id("confirmButton"));
        IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
        js.ExecuteScript("arguments[0].scrollIntoView(true);", confirmBoxButton);
        IWebElement consentButton = _driver.FindElement(By.XPath("//button[contains(@class, 'consent')]"));
        consentButton.Click();

        
        confirmBoxButton.Click();
        //in order to access the Alert we should switchTo
        var alert = _driver.SwitchTo().Alert();

        Assert.AreEqual("Do you confirm action?", alert.Text);

        alert.Accept();
    }

    [TestMethod]
    public void Dismiss_ConfirmationBox()
    {
        IWebElement confirmBoxButton = _driver.FindElement(By.Id("confirmButton"));
        confirmBoxButton.Click();
        //in order to access them we should switchTo
        var alert = _driver.SwitchTo().Alert();

        Assert.AreEqual("Do you confirm action?", alert.Text);

        alert.Dismiss();
    }

    public void SaveHtmlPage()
    {
        //get the pure HTML, the executed JavaScript is not included, the css
        System.Console.WriteLine(_driver.PageSource);
    }
}