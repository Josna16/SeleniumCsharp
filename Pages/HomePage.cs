using OpenQA.Selenium;
namespace Pages{
    public class HomePage{
        IWebDriver driver;
        public HomePage(IWebDriver driver){
            this.driver = driver;
        }

        string signIn = "//*[contains(text(), 'Sign In')]";
        string signInTitle = "//h1[contains(text(), 'Online Banking Login')]";
        string userName = "uid";
        string password = "passw";

        public void ClickOnSignIn(){
            IWebElement signInElement = driver.FindElement(By.XPath(signIn));
            signInElement.Click();
        }

        public string ValidateSignInPage(){
            IWebElement signInTitleElement = driver.FindElement(By.XPath(signInTitle));
            IWebElement userNameElement = driver.FindElement(By.Id(userName));
            IWebElement passwordElement = driver.FindElement(By.Id(password));
            if(signInTitleElement.Displayed && userNameElement.Displayed && passwordElement.Displayed){
                return "True";
            }else{
                return "False";
            }
            //return signInTitleElement.Displayed && userNameElement.Displayed && passwordElement.Displayed;
        }
    }
}