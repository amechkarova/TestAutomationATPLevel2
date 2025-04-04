using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.CommonModels;
using WebDriver.SpecFlow.Exercise.Base;
using WebDriver.SpecFlow.Exercise.Core;

namespace WebDriver.SpecFlow.Exercise.Pages.CartPage
{
    public partial class CartPage : BasePage
    {
        public Dress? DressAddedToCart;
        protected string SubPageUrl = "?controller=order";
        public CartPage(IWebDriver driver) : base(driver)
        { 
        }
        public override void NavigateTo()
        {
            Driver.Navigate().GoToUrl(string.Concat(DomainUrl, SubPageUrl));
        }
        public void CreateDress()
        {
            string[] sizeAndColor = DressDescription.Text.Split(":");
            string tempSize = sizeAndColor[1];
            string size = tempSize.Split(',')[0].Trim();
            string tempColor = sizeAndColor[2];
            string color = tempColor.Trim();
            int quantity = int.Parse(Quantity.GetAttribute("value"));

            DressAddedToCart = new Dress(DressName.Text, "", "", "", DressPrice.Text,
                      color, size, quantity);

        }
    }
}
