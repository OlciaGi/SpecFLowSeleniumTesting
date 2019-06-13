using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumberTESTING.pages
{
    class SelectedProductPage
    {
        public IWebDriver Driver;
        [FindsBy(How = How.CssSelector, Using = "div.container.with-below-header:nth-child(8) section.main:nth-child(3) div.col-right1.col-book:nth-child(3) aside.book-price.updateable:nth-child(1) div.book-price-bg div.our-price:nth-child(5) form.book-details:nth-child(2) > button.add-to-cart:nth-child(2)")]
        IWebElement addToCart;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Koszyk')]")]
        IWebElement goToBasket;

        public void GoBusket()
        {
            goToBasket.Click();
        }
        public void AddToCart()
        {
            addToCart.Click();
        }

        public SelectedProductPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            /*Assert.AreEqual("Gra o tron (George R.R. Martin) książka w księgarni TaniaKsiazka.pl", Driver.Title);*/
        }
    }
}
