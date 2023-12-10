using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class LoginPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    // Метод для відкриття сторінки в браузері
    public void OpenLoginPage(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    // Метод для вибору опції "Login as User"
    public void ClickLoginAsBankManager()
    {
        // Знайдіть елемент кнопки "Login as User" за допомогою селектора і натисніть на неї
        IWebElement loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='Bank Manager Login']")));
        loginButton.Click();
    }
    public void SelectCustomers()
    {
        // Знайдіть елемент випадаючого списку за допомогою селектора
        IWebElement customers = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[contains(text(),'Customers')]")));
        customers.Click();

    }

    public bool IsNameIsCorrect(string name)
    {
        IWebElement tdElement = driver.FindElement(By.XPath("//td[contains(@class, 'ng-binding')][1]"));
        string tdText = tdElement.Text;
        Thread.Sleep(3000);
        if (tdText == name)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public bool CheckIfSurnameIsCorrect(string Surname)
    {
        IWebElement tdElement = driver.FindElement(By.XPath("//td[contains(@class, 'ng-binding')][2]"));
        string tdText = tdElement.Text;
        Thread.Sleep(3000);
        if (tdText == Surname)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    public void PasteInSearchBar(string smth)
    {
        IWebElement searchInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//input[contains(@class,'form-control')]")));
        Thread.Sleep(2000);
        searchInput.Clear();
        Thread.Sleep(2000);
        searchInput.SendKeys(smth);

    }

    public bool CheckIfPostCodeIsCorrect(string PostCode)
    {
        IWebElement tdElement = driver.FindElement(By.XPath("//td[contains(@class, 'ng-binding')][3]"));
        string tdText = tdElement.Text;
        Thread.Sleep(2000);
        if (tdText == PostCode)
        {
            return true;
        }
        else
        {
            return false;
        }
    }




    public void CloseDriver()
    {
        driver.Quit();
    }

}
