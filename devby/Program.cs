using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using devby;

IWebDriver driver = new ChromeDriver();

HomePage devByioPage = new HomePage(driver);

int countVacations = devByioPage.CountVacation("Java");

devByioPage.CloseBanner();

InformationPage devByioPageVac = devByioPage.OpenPositionInfo("Java");

driver.SwitchTo().Window(driver.WindowHandles.Last());

devByioPageVac.PrintVacations();

if (devByioPageVac.CountVacations() == countVacations)
    {
    Console.WriteLine($"Count vacations {countVacations}");
    }
driver.Quit();



