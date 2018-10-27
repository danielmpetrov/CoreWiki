using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages
{
	public class HomePageAuthenticated
	{
		private readonly IWebDriver _driver;

		public HomePageAuthenticated(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement ManageAccountLink => _driver.FindElement(By.XPath(@"//*[@id=""navbarToggler""]/ul[2]/li[2]/a"));

		public AccountManagePage GoToAccountManage()
		{
			ManageAccountLink.Click();

			return new AccountManagePage(_driver);
		}
	}
}
