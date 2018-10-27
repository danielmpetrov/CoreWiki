using CoreWiki.Test.E2E.Pages.Account;
using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages
{
	public class ArticleDetailsAnonymous
	{
		private readonly IWebDriver _driver;

		public ArticleDetailsAnonymous(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement LoginLink => _driver.FindElement(By.LinkText("Login"));

		public IWebElement RegisterLink => _driver.FindElement(By.LinkText("Register"));

		public LoginPage GoToLoginPage()
		{
			LoginLink.Click();

			return new LoginPage(_driver);
		}

		public RegisterPage GoToRegisterPage()
		{
			RegisterLink.Click();

			return new RegisterPage(_driver);
		}
	}
}
