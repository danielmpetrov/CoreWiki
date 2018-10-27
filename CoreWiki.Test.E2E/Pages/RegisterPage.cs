using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages
{
	public class RegisterPage
	{
		private readonly IWebDriver _driver;

		public RegisterPage(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement EmailInput => _driver.FindElement(By.Id("Input_Email"));

		public IWebElement PasswordInput => _driver.FindElement(By.Id("Input_Password"));

		public IWebElement ConfirmPasswordInput => _driver.FindElement(By.Id("Input_ConfirmPassword"));

		public HomePageAuthenticated Register(string email, string password)
		{
			EmailInput.SendKeys(email);
			PasswordInput.SendKeys(password);
			ConfirmPasswordInput.SendKeys(password);
			ConfirmPasswordInput.Submit();
			return new HomePageAuthenticated(_driver);
		}
	}
}
