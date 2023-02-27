using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Globalization;

namespace devby
{
    internal class HomePage: DevBasePage
    {
        ReadOnlyCollection<IWebElement> _jobPositions;
        IWebElement _banner;
        const string SITE_PARTS_MENU_POSITIONS = "//div[@class='grid__item grid__item_sm']";
        const string SITE_BANNER = "//div[@class='grippy-host']";
        
        public HomePage(IWebDriver driver):base(driver) 
        {     
            GoToUrl("https://devby.io/");
            InitializePositionsElements();      
        }
                
        private void InitializePositionsElements()
        {
            _jobPositions = FindDevByElements(SITE_PARTS_MENU_POSITIONS);
        }

        public InformationPage OpenPositionInfo(string positionName)
        {
            var element = _jobPositions.Where(x => x.Text.Contains(positionName)).FirstOrDefault();

            ClickElement(element);
            return new InformationPage(_driver);
        }

        public IWebElement GetVacation(string nameVacation)
        {
            var element = _jobPositions.Where(x => x.Text.Contains(nameVacation)).FirstOrDefault();
            return element;
            
        }
        
        public int CountVacation (string nameVacation)
        {
            var element = GetVacation(nameVacation);
            string textVacation = element.Text;    
            string res = "";
            foreach (char i in textVacation)
            {
                if (Char.GetUnicodeCategory(i) == UnicodeCategory.DecimalDigitNumber)
                {
                    res = res + i;
                }

            }
            int count = Int32.Parse(res);
            return count;
        }

        public void CloseBanner()
        {
            Thread.Sleep(3000);
            _banner = FindDevByElements(SITE_BANNER).First();
            ClickElement(_banner);
        }




    } 
}
