using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using src.core.settings;

namespace src.core.domain
{
    public abstract class  BaseWebDriver
    {
        public IWebDriver driver { get; set; }
        public UrlSetting url;
        public CredentialSetting credential;
        
        public BaseWebDriver()
        {
            this.url = new UrlSetting();
            this.credential = new CredentialSetting();

            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        public BaseWebDriver(string url)
        {   
            this.url = new UrlSetting();
            this.credential = new CredentialSetting();

            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
            this.NavigateTo(url);
        }

        public void NavigateTo(string url){
            this.driver.Url = url;
        }
        
        public void Wait(int miliseconds){
            System.Threading.Thread.Sleep(miliseconds);
        }

        public void SetTextValueById(string id, string value){
           this.driver.FindElement(By.XPath($"//input[@id='{id}']")).Clear();
           this.driver.FindElement(By.XPath($"//input[@id='{id}']")).SendKeys(value);
        }

        public void ClickButtonSubmit(){
           var button = this.driver.FindElement(By.XPath($"//input[@type='submit']"));
           button.Click();
        }

    }
}