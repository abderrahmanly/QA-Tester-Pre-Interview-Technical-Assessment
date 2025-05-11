
using NUnit.Framework;
using OpenQA.Selenium;

[TestFixture]
public class LoginTests : BaseTest
{
    [Test]
    public void LoginWithValidCredentials()
    {
        driver.Navigate().GoToUrl(baseUrl + "/login");
        driver.FindElement(By.Id("email")).SendKeys("newuser@example.com");
        driver.FindElement(By.Id("password")).SendKeys("password123");
        driver.FindElement(By.Id("submit")).Click();
        Assert.IsTrue(driver.Url.Contains("/profile"));
    }
}
