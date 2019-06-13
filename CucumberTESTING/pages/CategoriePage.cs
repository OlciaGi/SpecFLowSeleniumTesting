using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CucumberTESTING.pages
{
    class CategoriePage
    {
        public IWebDriver Driver;
        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-9']//li[1]//div[1]//div[1]//a[1]//img[1]")]
        IWebElement selectBook;

        public void ClickBook()
        {
            selectBook.Click();

        }
        public CategoriePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }
    
    public void SrollD()
    {
        IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
        js.ExecuteScript("window.scrollBy(0,250");

    }
}
}
