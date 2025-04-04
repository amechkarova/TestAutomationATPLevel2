using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver.SpecFlow.Exercise.Pages.Dresses
{
    public partial class DressesPage
    {
        public ReadOnlyCollection<IWebElement> Dresses => Driver.FindElements(By.XPath("//li[contains(@class, 'ajax_block_product')]"));
        public IWebElement DressNameInQuickView => Driver.FindElement(By.CssSelector("[itemprop='name']"));
        public IWebElement AddToCompareButton1 => Driver.FindElement(By.XPath("//a[@class='add_to_compare'][@data-id-product='3']"));
        public IWebElement AddToCompareButton2 => Driver.FindElement(By.XPath("//a[@class='add_to_compare'][@data-id-product='4']"));
        public IWebElement CompareButton => Driver.FindElement(By.XPath("//button[contains(@class, 'compare')]"));
        public IWebElement CompareButtonProductCount => Driver.FindElement(By.XPath("//input[@name='compare_product_count']"));
        public ReadOnlyCollection<IWebElement> QuickViews => Driver.FindElements(By.XPath("//a[@class='quick-view']"));
        public IWebElement Iframe => Driver.FindElement(By.CssSelector("[class='fancybox-iframe']"));
        public IWebElement SizeDropDown => Driver.FindElement(By.Id("group_1"));
        public IWebElement MSize => Driver.FindElement(By.XPath("//select[@id='group_1']//option[@title='M']"));
        public IWebElement LSize => Driver.FindElement(By.XPath("//select[@id='group_1']//option[@title='L']"));
        public IWebElement SSize => Driver.FindElement(By.XPath("//select[@id='group_1']//option[@title='S']"));
        public IWebElement ColorOrange => Driver.FindElement(By.Id("color_13"));
        public IWebElement ColorBlack => Driver.FindElement(By.Id("color_11"));
        public IWebElement ColorBlue => Driver.FindElement(By.Id("color_14"));
        public IWebElement ColorYellow => Driver.FindElement(By.Id("color_16"));
        public IWebElement ColorBeige => Driver.FindElement(By.Id("color_7"));
        public IWebElement ColorPink => Driver.FindElement(By.Id("color_24"));
        public IWebElement Quantity => Driver.FindElement(By.Id("quantity_wanted"));
        public IWebElement DressPriceInQuickView => Driver.FindElement(By.Id("our_price_display"));
        public IWebElement ContinueShopping => Driver.FindElement(By.CssSelector("[title='Continue shopping']"));
        public IWebElement ProceedToCheckout => Driver.FindElement(By.CssSelector("[title='Proceed to checkout']"));
        public IWebElement AddToCartFromQuickView => Driver.FindElement(By.CssSelector("[class='exclusive']"));
        public IWebElement AvailabilityValue => Driver.FindElement(By.Id("availability_value"));

    }
}
