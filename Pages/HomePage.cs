using OpenQA.Selenium;
using SeleniumHelpers;
namespace Pages{
    public class HomePage{
        IWebDriver driver;
        public HomePage(IWebDriver driver){
            this.driver = driver;
        }

        string signInLocator = "//*[contains(text(), 'Sign In')]";
        string signInTitleLocator = "//h1[contains(text(), 'Online Banking Login')]";
        string userNameLocator = "uid";
        string passwordLocator = "passw";
        string loginButtonLocator = "btnSubmit";
        string loginValidationLocator = "//p[contains(text(), 'Welcome to Altoro Mutual')]";
        string invaldLoginLocator = "//*[contains(text(), 'Login Failed')]";

        public void ClickOnSignIn(){
            IWebElement signInElement = driver.FindElement(By.XPath(signInLocator));
            signInElement.Click();
        }

        public bool ValidateSignInPage(){
            IWebElement signInTitleElement = driver.FindElement(By.XPath(signInTitleLocator));
            IWebElement userNameElement = driver.FindElement(By.Id(userNameLocator));
            IWebElement passwordElement = driver.FindElement(By.Id(passwordLocator));
            return signInTitleElement.Displayed && userNameElement.Displayed && passwordElement.Displayed;
        }

        public void EnterLoginCredentials(string userName, string password){
            IWebElement userNameElement = driver.FindElement(By.Id(userNameLocator));
            userNameElement.SendKeys(userName);
            IWebElement passwordElement = driver.FindElement(By.Id(passwordLocator));
            passwordElement.SendKeys(password);
            IWebElement loginButtonElement = driver.FindElement(By.Name(loginButtonLocator));
            loginButtonElement.Click();
        }

        public bool ValidateUserIsSignedIn(){
            IWebElement loginValidationElement = driver.FindElement(By.XPath(loginValidationLocator));
            Logger.LogInfo("Validate if the Welcome message is displayed");
            Thread.Sleep(3000);
            return loginValidationElement.Displayed;
        }

        public bool ValidateInvalidSignIn(){
            IWebElement InvalidLoginValidationElement = driver.FindElement(By.XPath(invaldLoginLocator));
            Logger.LogInfo("Validate if the Login Failed message is displayed");
            Thread.Sleep(3000);
            return InvalidLoginValidationElement.Displayed;
        }
    }
}