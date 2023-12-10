using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YourProjectNamespace
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        public LoginSteps()
        {
            // Ініціалізуємо драйвер у конструкторі
            driver = new ChromeDriver(); // Ви можете вибрати інший драйвер за потребою
            loginPage = new LoginPage(driver);
        }

        [Given(@"I am on the banking website")]
        public void GivenIAmOnTheBankingWebsite()
        {
            loginPage.OpenLoginPage("https://www.globalsqa.com/angularJs-protractor/BankingProject"); // Замініть URL на реальний URL вашого веб-сайту
        }

        [When(@"I select ""Login as Bank Manager"" option")]
        public void WhenISelectLoginAsUserOption()
        {
            loginPage.ClickLoginAsBankManager();
        }

        [When(@"I select customers")]

        public void WhenISelectCustomers()
        {
            loginPage.SelectCustomers();
        }

        [When(@"I write to search bar name")]

        public void WhenIClickTheSearchBarAndWriteName()
        {
            loginPage.PasteInSearchBar("Albus");
        }

        [Then(@"I should check if the name is correct")]
        public void ThenIShouldSeeTheMainDivBlock()
        {
            bool isMainDivVisible = loginPage.IsNameIsCorrect("Albus");
            Assert.IsTrue(isMainDivVisible, "The name is incorrect");
        }

        [When(@"I should write surname to the search-bar")]

        public void WhenIClickWithdraw()
        {
            loginPage.PasteInSearchBar("Weasly");
        }

        [Then(@"I should check if the Surname is correct")]
        public void ThenIShouldSeeTheMainDivBloc2()
        {
            bool isMainDivVisible = loginPage.CheckIfSurnameIsCorrect("Weasly");
            Assert.IsTrue(isMainDivVisible, "The Surname is incorrect");
        }


        [When(@"I should write PostCode to the search-bar")]

        public void WritePostCode()
        {
            loginPage.PasteInSearchBar("E859AB");
        }

        [Then(@"I should check if the PostCode is correct")]
        public void CheckIfPostCode()
        {
            bool isMainDivVisible = loginPage.CheckIfPostCodeIsCorrect("E859AB");
            Assert.IsTrue(isMainDivVisible, "The PostCode is incorrect");
        }

        [Then(@"I should close Chrome")]
        public void CloseChrome()
        {
            loginPage.CloseDriver();
        }
    }
}
