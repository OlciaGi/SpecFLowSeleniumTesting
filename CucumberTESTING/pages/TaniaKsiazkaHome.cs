using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;


namespace CucumberTESTING.pages
{
    class TaniaKsiazkaHome
    {
        public IWebDriver Driver;
        [FindsBy(How = How.XPath, Using = "//input[@id='inputSearch']")]
        IWebElement searchArea;

        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        IWebElement searchButton;

       

        public TaniaKsiazkaHome(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public void SearchAreaTypes()
        {
            searchArea.SendKeys("Igrzyska śmierci");
        }
        public void SearchButtonclick()
        {
            searchButton.Click();
        }
        
    }
}



   
