using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages.Account
{
	public class LoginPage
	{
		private IWebDriver _driver;

		public LoginPage(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement InputEmail => _driver.FindElement(By.Id("Input_Email"));

		public IWebElement InputPassword => _driver.FindElement(By.Id("Input_Password"));

		public ArticleDetailsAuthenticated Login(string email, string password)
		{
			InputEmail.SendKeys(email);
			InputPassword.SendKeys(password);
			InputPassword.Submit();
			return new ArticleDetailsAuthenticated(_driver);
		}
	}
}
