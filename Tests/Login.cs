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
        homePageObj = new HomePage(driver);
        sel.LaunchUrl(driver);
    }

    [Test]
    public void ValidLogin()
    {
        Logger.LogInfo("Click on the signin button in the home page.");
        homePageObj.ClickOnSignIn();
        Logger.LogInfo("Validate that user is navigated to the signin page.");
        Assert.That(homePageObj.ValidateSignInPage(), Is.True, "User is navigated to the signin page.");
        homePageObj.EnterLoginCredentials("jsmith", "Demo1234");
        Assert.That(homePageObj.ValidateUserIsSignedIn(), Is.True, "User is sucessfully loged in.");
    }
    [Test]
    public void InvalidLogin(){
        Logger.LogInfo("Click on the signin button in the home page.");
        homePageObj.ClickOnSignIn();
        Logger.LogInfo("Validate that user is navigated to the signin page.");
        Assert.That(homePageObj.ValidateSignInPage(), Is.True, "User is navigated to the signin page.");
        homePageObj.EnterLoginCredentials("invalid", "invalid");
        Assert.That(homePageObj.ValidateInvalidSignIn(), Is.True, "The login failed message is displayed.");
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
