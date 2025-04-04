using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver.SpecFlow.Exercise.Pages.CartPage
{
    public partial class CartPage
    {
        public IWebElement DressName => Driver.FindElement(By.XPath("//table[@id='cart_summary']//p[@class='product-name']/a"));
        public IWebElement DressPrice => Driver.FindElement(By.XPath("//td[contains(@class, 'cart_unit')]//li[@class='price']"));
        public IWebElement DressDescription => Driver.FindElement(By.XPath("//table[@id='cart_summary']//small/a"));
        public IWebElement Quantity => Driver.FindElement(By.XPath("//td[contains(@class, 'cart_quantity')]/input[@type='hidden']"));
        public IWebElement EmptyCartAlert => Driver.FindElement(By.CssSelector("[class='alert alert-warning']"));
    }
}
