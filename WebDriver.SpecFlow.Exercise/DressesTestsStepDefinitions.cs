using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using WebDriver.SpecFlow.Core;
using WebDriver.SpecFlow.Exercise.Core;
using WebDriver.SpecFlow.Exercise.Pages.CartPage;
using WebDriver.SpecFlow.Exercise.Pages.DressCharacteristics;
using WebDriver.SpecFlow.Exercise.Pages.Dresses;

namespace WebDriver.SpecFlow.Exercise
{
    [Binding]
    public class DressesTestsStepDefinitions
    {
        private DressesPage _dressesPage;
        private DressesComparisonPage _dressesComparisonPage;
        private CartPage _cartPage;
        private bool _isDressAddedToCart;
        Dress dress1 = new Dress("Printed Summer Dress", "Viscose", "Casual", "Maxi Dress", "$29", "Yellow",
            "M", 2);
        Dress dress2 = new Dress("Printed Dress", "Cotton", "Girly", "Colorful Dress", "$26", "Orange",
            "M", 3);
        Dress dress3 = new Dress("Printed Dress", "Viscose", "Dressy", "Short Dress", "$51", "Pink",
            "M", 3);
        List<Dress> _dresses = new List<Dress> {new Dress("Printed Dress", "Cotton", "Girly", "Colorful Dress", "$26", "Orange",
            "M", 3), new Dress("Printed Dress", "Viscose", "Dressy", "Short Dress", "$51", "Pink",
            "M", 3)};
        Dress dressWithModifiedDetails;
        


        [Given(@"Start Web browser")]
        public void GivenStartWebBrowser()
        {
            Driver.StartBrowser(BrowserTypes.Chrome);
        }

        [When(@"I navigate to the Shopping site")]
        public void WhenINavigateToTheShoppingSite()
        {
            _dressesPage = new DressesPage(Driver.Browser);
            _dressesPage.NavigateTo();
        }

        [When(@"I add dresses for comparison")]
        public void WhenIAddDressesForComparison()
        {
            _dressesPage.AddDressesToCompare();
            _dressesPage.WaitForAjax();
        }

        [When(@"I open the comparison page")]
        public void WhenIOpenTheComparisonPage()
        {
            _dressesPage.CompareButton.Click();
        }

        [Then(@"assert that the two dresses are added for comparison")]
        public void ThenAssertThatTheTwoDressesAreAddedForComparison()
        {
            _dressesComparisonPage = new DressesComparisonPage(Driver.Browser);
            _dressesComparisonPage.NavigateTo();
            Assert.AreEqual(_dresses[0].Name, _dressesComparisonPage.Names[0].Text);
            Assert.AreEqual(_dresses[1].Name, _dressesComparisonPage.Names[1].Text);

        }

        [Then(@"verify the information displayed on the comparison screen")]
        public void ThenVerifyTheInformationDisplayedOnTheComparisonScreen()
        {
            Assert.IsTrue(_dressesComparisonPage.VerifyDressInfoInComparisonPage(_dresses));
        }

        [Then(@"Close Web browser")]
        public void ThenCloseWebBrowser()
        {
            Driver.StopBrowser();
        }

        [When(@"I open a dress's Quick View")]
        public void WhenIOpenADresssQuickView()
        {
            _dressesPage.OpenDressForQuickView();
        }

        [Then(@"assert the displayed information")]
        public void ThenAssertTheDisplayedInformation()
        {
            Assert.AreEqual(_dresses[1].Name, _dressesPage.DressNameInQuickView.Text);
            Assert.AreEqual(_dresses[1].Price, _dressesPage.DressPriceInQuickView.Text);
        }

        //[When(@"I set the wanted details")]
        //public void WhenISetTheWantedDetails()
        //{
        //    dressWithModifiedDetails = new Dress(_dresses[1].Name, _dresses[1].Composition, _dresses[1].Style,
        //        _dresses[1].Property, _dresses[1].Price, "Pink", "M", 2);
        //    _dressesPage.SetDressDetails(dressWithModifiedDetails);
        //}

        [When(@"I set the wanted details (.*) (.*) (.*)")]
        public void WhenISetTheWantedDetailsSPinkQuantity(string size, string color, string quantity)
        {
            dressWithModifiedDetails = new Dress(_dresses[1].Name, _dresses[1].Composition, _dresses[1].Style,
                _dresses[1].Property, _dresses[1].Price, color, size, int.Parse(quantity));
            _dressesPage.SetDressDetails(dressWithModifiedDetails);
        }


        [When(@"I add it to the cart")]
        public void WhenIAddItToTheCart()
        {
           _isDressAddedToCart = _dressesPage.AddToCart();  
        }

        [Then(@"assert that the dress is added to the cart")]
        public void ThenAssertThatTheDressIsAddedToTheCart()
        {
            _cartPage = new CartPage(Driver.Browser);
            _cartPage.NavigateTo();

            if (_isDressAddedToCart)
            {
                
                _cartPage.CreateDress();
                Assert.AreEqual(dressWithModifiedDetails.Name, _cartPage.DressAddedToCart.Name);
                Assert.AreEqual(dressWithModifiedDetails.Price, _cartPage.DressAddedToCart.Price);
                Assert.AreEqual(dressWithModifiedDetails.Color, _cartPage.DressAddedToCart.Color);
                Assert.AreEqual(dressWithModifiedDetails.Size, _cartPage.DressAddedToCart.Size);
                Assert.AreEqual(dressWithModifiedDetails.Quantity, _cartPage.DressAddedToCart.Quantity);
            }
            else
            {
                Assert.AreEqual("Your shopping cart is empty.", _cartPage.EmptyCartAlert.Text);
            }
        }
    }
}
