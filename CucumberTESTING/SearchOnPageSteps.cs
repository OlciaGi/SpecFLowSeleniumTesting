using CucumberTESTING.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace CucumberTESTING
{
    [Binding]
    public class SearchOnPageSteps
    {
        private readonly IWebDriver _nDriver;
        private readonly IWait<IWebDriver> _Wait;
        private TaniaKsiazkaHome _taniaKsiazkaHome;
        private CategoriePage _categoriePage;
        private SelectedProductPage _selectedProductPage;
        private SearchedBookPage _searchedBookPage;

        public SearchOnPageSteps()
        {
            _nDriver = new ChromeDriver();
            _Wait = new WebDriverWait(_nDriver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(100)
            };
            _nDriver.Manage().Window.Maximize();
        }
        [Given(@"User open TaniaKsiazka page")]
        public void GivenUserOpenTaniaKsiazkaPage()
        {
            _nDriver.Navigate().GoToUrl("https://www.taniaksiazka.pl/");
            _taniaKsiazkaHome = new TaniaKsiazkaHome(_nDriver);

        }

        [When(@"User type searched phrase")]
        public void WhenUserTypeSearchedPhrase()
        {
            _taniaKsiazkaHome.SearchAreaTypes();
        }

        [When(@"User click enter")]
        public void WhenUserClickEnter()
        {
            _taniaKsiazkaHome.SearchButtonclick();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"Searched phrase is displayed")]
        public void ThenSearchedPhraseIsDisplayed()
        {
            _searchedBookPage = new SearchedBookPage(_nDriver);
            System.Threading.Thread.Sleep(2000);
            _searchedBookPage.Asercja();
            

        }
        [When(@"User chose Fantastyka from categories")]
        public void WhenUserChoseFantastykaFromCategories()
        {
           
            _searchedBookPage.ClickKategorie();
            _searchedBookPage.MoveOnFantastyka();
            _searchedBookPage.ClickOnFantastyka();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"User click on Book")]
        public void WhenUserClickOnBook()
        {
            
            _categoriePage = new CategoriePage(_nDriver);
            Assert.AreEqual("Fantastyka i fantasy", _nDriver.Title);
            _categoriePage.ClickBook();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"User adds book to the basket")]
        public void WhenUserAddsBookToTheBasket()
        {
            _selectedProductPage = new SelectedProductPage(_nDriver);
            _selectedProductPage.AddToCart();
            /*_selectedProductPage.SrollD();
            _selectedProductPage.GoBusket();*/
        }

        [Then(@"Book added to the basket")]
        public void ThenBookAddedToTheBasket()
        {
            Assert.AreEqual("Produkt dodany do koszyka", _nDriver.FindElement(By.XPath("//article[@class='koszyk-dodaj book-list']//header")).Text);
        }
        [AfterScenario]
        public void QuitBrowser()
        {
            _nDriver.Quit();
        }

    }

}
