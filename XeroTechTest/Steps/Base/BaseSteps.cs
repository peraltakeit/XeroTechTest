using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace XeroTechTest.Steps.Base
{
    public abstract class BaseSteps
    {
        protected readonly IWebDriver _driver;
        protected IObjectContainer _objectContainer;
        protected readonly ScenarioContext _scenarioContext;
        protected readonly FeatureContext _featureContext;

        public BaseSteps(IWebDriver driver, IObjectContainer objectContainer, ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _driver = driver;
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }
    }
}
