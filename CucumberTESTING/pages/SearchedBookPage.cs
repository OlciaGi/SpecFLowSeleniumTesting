using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumberTESTING.pages
{
    class SearchedBookPage
    {
        public IWebDriver Driver; 
        [FindsBy(How = How.XPath, Using = "//a[@class='arrow']")]
        IWebElement clickKategorie;

        [FindsBy(How = How.XPath, Using = "//ul[@class='vertical-col']//a[contains(text(),'Fantastyka')]")]
        IWebElement clickFantastyka;
        public SearchedBookPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }
        public void Asercja()
        {
            Assert.AreEqual("Igrzyska śmierci", Driver.Title);
        }

        public void ClickKategorie()
        {
            clickKategorie.Click();
        }
        public void MoveOnFantastyka()
        {
            Actions actions = new Actions(Driver);
            actions.Build();
            actions.MoveToElement(clickFantastyka, 0, 0);
            actions.Perform();
        }
        public void ClickOnFantastyka()
        {
            clickFantastyka.Click();
        
        }
        public void SrollD()
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,250");

        }

    }
}
