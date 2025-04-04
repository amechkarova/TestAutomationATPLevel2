using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.SpecFlow.Exercise.Base;
using WebDriver.SpecFlow.Exercise.Core;
using static System.Net.Mime.MediaTypeNames;

namespace WebDriver.SpecFlow.Exercise.Pages.Dresses
{
    public partial class DressesPage : BasePage
    {
        protected string SubPageUrl = "?id_category=8&controller=category";
        public DressesPage(IWebDriver driver)
            : base(driver)
        {
        }

        public override void NavigateTo()
        {
            Driver.Navigate().GoToUrl(string.Concat(DomainUrl, SubPageUrl));
        }

        public void AddDressesToCompare()
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(Dresses[0]).Perform();
            DriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='add_to_compare'][@data-id-product='3']")));
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click();", AddToCompareButton1);
            WaitForAjax();
            actions.MoveToElement(Dresses[1]).Perform();
            DriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='add_to_compare'][@data-id-product='4']")));
            js.ExecuteScript("arguments[0].click();", AddToCompareButton2);
        }

        public void CompareTheAddedDresses()
        {
            if(CompareButtonProductCount.Text != "0" && CompareButtonProductCount.Text != "1")
            {
                CompareButton.Click();
            }     
        }

        public void VerifyDressesAreAddedForComparison()
        {
            Assert.AreEqual("2", CompareButtonProductCount.GetAttribute("value"), @"The counter of the Compare button is not 2.");
        }

        public void OpenDressForQuickView()
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(Dresses[1]).Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].click();", QuickViews[1]);
            Driver.SwitchTo().Frame(Iframe);
        }

        public void SetDressDetails(Dress dress)
        {
            SelectElement sizeDropdown = new SelectElement(SizeDropDown);            
            switch (dress.Size)
            {
                case "S": sizeDropdown.SelectByText("S"); break;
                case "M": sizeDropdown.SelectByText("M"); break;
                case "L": sizeDropdown.SelectByText("L"); break;
                default: throw new InvalidDataException();
            }

            switch(dress.Color)
            {
                case "Orange": ColorOrange.Click(); break;
                case "Black": ColorBlack.Click(); break;
                case "Blue": ColorBlue.Click(); break;
                case "Yellow": ColorYellow.Click(); break;
                case "Pink": ColorPink.Click(); break;
                case "Beige": ColorBeige.Click(); break;
                default: throw new InvalidDataException();
            }

            WaitForAjax();
            if (AvailabilityValue.Text == "In stock")
            {
                DriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("quantity_wanted")));
                Quantity.Clear();
                Quantity.SendKeys(dress.Quantity.ToString());
            }
        }

        public bool AddToCart()
        {
            bool dressIsAddedToCart = false;
            if (AvailabilityValue.Text == "In stock")
            {
                AddToCartFromQuickView.Click();
                dressIsAddedToCart = true;
                Driver.SwitchTo().DefaultContent();
                DriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[title='Proceed to checkout']")));
                ProceedToCheckout.Click();
            }

            return dressIsAddedToCart;
        }
    }
}
