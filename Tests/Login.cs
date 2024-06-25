using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumHelpers;
using Pages;
namespace Tests{
public class First{ 
    IWebDriver driver;
    SelHelpers sel;
    HomePage homePageObj;
    [SetUp]
    public void Setup()
    {
        sel = new SelHelpers();
        driver = new ChromeDriver();
        homePageObj = new(driver);
        sel.LaunchUrl(driver);
    }

    [Test]
    public void ValidLogin()
    {
        // IWebElement login =  driver.FindElement(By.XPath("//*[contains(text(), 'Sign In')]"));
        // login.Click();
        // IWebElement heading = driver.FindElement(By.TagName("h1"));
        // TestContext.Progress.WriteLine(heading.GetAttribute("text"));
        homePageObj.ClickOnSignIn();
        //string expected = "True";
        //NUnit.Framework.Assert.AreEqual(expected, "True");
        //Assert.AreEqual(homePageObj.ValidateSignInPage(), "True");
    }
    [Test]
    public void InvalidLogin(){
        TestContext.Out.WriteLine("Invalid");
    }

    [TearDown]
    public void Close(){
        if (driver != null)
        {
            sel.Close(driver);
        }
    }
    }
}
