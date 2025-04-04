using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.SpecFlow.Exercise.Base;
using WebDriver.SpecFlow.Exercise.Core;

namespace WebDriver.SpecFlow.Exercise.Pages.DressCharacteristics
{
    public partial class DressesComparisonPage : BasePage
    {
        private List<Dress> Dresses = new List<Dress>();
        protected string SubPageUrl = "?controller=products-comparison&compare_product_list=3%7C4";
        public DressesComparisonPage(IWebDriver driver) : base(driver)
        {
        }
        public override void NavigateTo()
        {
            Driver.Navigate().GoToUrl(string.Concat(DomainUrl, SubPageUrl));
        }
        private void CreateDresses()
        {
            int count = DressesToCompare.Count;
            for (int i = 0; i < count; i++)
            {
                Dress dressToAdd = new Dress(Names[i].Text, DressesCharacteristics[i].Text, DressesCharacteristics[i + count].Text,
                    DressesCharacteristics[i + 2*count].Text, Prices[i].Text, "Orange", "S", 1);
                Dresses.Add(dressToAdd);
            }
        }

        public bool VerifyDressInfoInComparisonPage(List<Dress> ExpectedDresses)
        {
            bool result = true;
            CreateDresses();
            for (int i = 0;i < ExpectedDresses.Count;i++)
            {
                if (Dresses[i].Name == ExpectedDresses[i].Name && Dresses[i].Composition == ExpectedDresses[i].Composition
                        && Dresses[i].Style == ExpectedDresses[i].Style && Dresses[i].Property == ExpectedDresses[i].Property 
                        && Dresses[i].Price == ExpectedDresses[i].Price)
                {
                    continue;
                }

                result = false;
            }

            return result;
        }
    }
}
