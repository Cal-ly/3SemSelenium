using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium;

[TestClass]
public class HelloWorld2Tests
{
    private ChromeDriver driver = null!;

    [TestInitialize]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://calm-field-0c1448703.4.azurestaticapps.net/"); // Update with your local server URL
    }

    [TestMethod]
    public void TestShowAlert()
    {
        // Find the button using its class name and click it
        var button = driver.FindElement(By.ClassName("btn-success"));
        button.Click();

        // Switch to the alert and verify its text
        IAlert alert = driver.SwitchTo().Alert();
        Assert.AreEqual("Bootstrap er korrekt hentet!", alert.Text);

        // Accept the alert
        alert.Accept();
    }

    [TestCleanup]
    public void TearDown()
    {
        //Thread.Sleep(5000); // Wait for 5 seconds before closing
        driver.Quit();
    }
}
