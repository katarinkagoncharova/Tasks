using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;


namespace devby

{
    internal abstract class DevBasePage
    {
        protected IWebDriver _driver;
        Actions _action;

        protected DevBasePage(IWebDriver driver)
        { 
            _driver = driver;
            _action = new Actions(driver);

        }

        protected void GoToUrl(string url)
        {
            _driver.Url = url;
            _driver.Manage().Window.Maximize();
        }

        protected void ClickElement(IWebElement webElement)
        {
            _action.MoveToElement(webElement);
            _action.Perform();
            webElement.Click();
        }

        protected ReadOnlyCollection<IWebElement> FindDevByElements(string xPath)
        {
            int countNum = 0;
            while (countNum < 10)
            {
                try
                {
                    ReadOnlyCollection<IWebElement> elements = _driver.FindElements(By.XPath(xPath));
                    return elements;
                }
                catch (Exception ex) 
                {
                    Thread.Sleep(100);
                    countNum++;
                }
            }
            return null;
        }

       


    }
}
