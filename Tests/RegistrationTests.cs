
using NUnit.Framework;
using OpenQA.Selenium;

[TestFixture]
public class RegistrationTests : BaseTest
{
    [Test]
    public void SuccessfulRegistration()
    {
        driver.Navigate().GoToUrl(baseUrl + "/register");
        driver.FindElement(By.Id("email")).SendKeys("newuser@example.com");
        driver.FindElement(By.Id("password")).SendKeys("password123");
        driver.FindElement(By.Id("submit")).Click();
        Assert.IsTrue(driver.Url.Contains("/login"));
    }
}
