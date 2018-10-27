using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages.Account.Manage
{
	public class DeletePersonalDataPage
	{
		private IWebDriver _driver;

		public DeletePersonalDataPage(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement PasswordInput => _driver.FindElement(By.Id("Input_Password"));

		public void DeleteAccount(string password)
		{
			PasswordInput.SendKeys(password);
			PasswordInput.Submit();
		}
	}
}
