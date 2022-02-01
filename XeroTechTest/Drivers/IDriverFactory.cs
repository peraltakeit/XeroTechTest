using OpenQA.Selenium;

namespace XeroTechTest.Drivers
{
    public interface IDriverFactory
    {
        IWebDriver GetDriver();
        DriverOptions GetOptions();
        IDriverFactory SetHeadless(bool isHeadless);
    }
}
