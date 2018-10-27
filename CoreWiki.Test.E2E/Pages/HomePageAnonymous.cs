using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages
{
	public class HomePageAnonymous
	{
		private readonly IWebDriver _driver;

		public HomePageAnonymous(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement RegisterLink => _driver.FindElement(By.LinkText("Register"));

		public HomePageAnonymous HavigateToSelf()
		{
			_driver.Navigate().GoToUrl("https://localhost:8081/");

			return this;
		}

		public RegisterPage GoToRegisterPage()
		{
			RegisterLink.Click();

			return new RegisterPage(_driver);
		}
	}
}
