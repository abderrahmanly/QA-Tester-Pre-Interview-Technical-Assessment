
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

public class BaseTest
{
    protected IWebDriver driver;
    protected string baseUrl = "http://localhost:3000";

    [SetUp]
    public void Setup()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        driver = new ChromeDriver(options);
    }

    [TearDown]
    public void Teardown()
    {
        driver.Quit();
    }
}
