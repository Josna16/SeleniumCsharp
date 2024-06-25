using OpenQA.Selenium;
namespace SeleniumHelpers{
    public class SelHelpers{
        //IWebDriver driver;
        public void LaunchUrl(IWebDriver driver){
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds((int)3000);
            driver.Navigate().GoToUrl("http://demo.testfire.net/");
            driver.Manage().Window.Maximize();
        }
        public void Close(IWebDriver driver){
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            if (testStatus == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                var screenshotsDirectory = "C:\\Users\\Josna Baby\\SeleniumC#\\Screenshots";
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string testName = TestContext.CurrentContext.Test.Name;
                var filePath = Path.Combine(screenshotsDirectory, $"{testName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
                screenshot.SaveAsFile(filePath);
            }           
            driver.Quit();
        }
    }
}