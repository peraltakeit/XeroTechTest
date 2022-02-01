using BoDi;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using XeroTechTest.Drivers;

namespace XeroTechTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;

        public Hooks(IObjectContainer objectContainer, FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Setup()
        {
            var browser = "chrome";
            var headless = false;
            var implicitWait = 2;
            var Url = "https://www.xero.com/nz/";

            IWebDriver driver = FactoryBuilder.GetFactory(browser).SetHeadless(headless).GetDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Url);
            _objectContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            IWebDriver driver = _objectContainer.Resolve<IWebDriver>();
            driver.Quit();
        }
    }
}
