using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Xml.Linq;


namespace devby
{
    internal class InformationPage:DevBasePage
    {
        ReadOnlyCollection<IWebElement> _listVacancies;
        const string SITE_PARTS_VACANCIES = "//a[@class='vacancies-list-item__link_block']";

        public InformationPage(IWebDriver driver) : base(driver)
        {
            _listVacancies = FindDevByElements(SITE_PARTS_VACANCIES);
            
        }

        public ReadOnlyCollection<IWebElement> GetListVacation()
        {
            return FindDevByElements(SITE_PARTS_VACANCIES);
        }

        public void PrintVacations() 
        {
            var vacation = GetListVacation();

            Console.WriteLine("Available vacancies:");

            foreach (var element in vacation) 
            {
                Console.WriteLine(element.Text);
            }
        }

        public int CountVacations()
        { 
            return GetListVacation().Count;
        }




    }
}
