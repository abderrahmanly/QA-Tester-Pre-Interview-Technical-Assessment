
using NUnit.Framework;
using OpenQA.Selenium;

[TestFixture]
public class LogoutTests : BaseTest
{
    [Test]
    public void LogoutUser()
    {
        driver.Navigate().GoToUrl(baseUrl + "/login");
        driver.FindElement(By.Id("email")).SendKeys("newuser@example.com");
        driver.FindElement(By.Id("password")).SendKeys("password123");
        driver.FindElement(By.Id("submit")).Click();
        driver.FindElement(By.Id("logout")).Click();
        Assert.IsTrue(driver.Url.Contains("/login"));
    }
}
