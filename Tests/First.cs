using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumHelpers;
namespace Tests{
public class First{ 
    IWebDriver driver;
    SelHelpers sel;
    [SetUp]
    public void Setup()
    {
        sel = new SelHelpers();
        driver = new ChromeDriver();
    }

    [Test]
    public void Test()
    {
        driver.Url = "http://demo.testfire.net/";
        Assert.Fail();
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
