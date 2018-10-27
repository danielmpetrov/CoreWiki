using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages
{
	public class DeletePersonalDataPage
	{
		private IWebDriver _driver;

		public DeletePersonalDataPage(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement PasswordInput => _driver.FindElement(By.Id("Input_Password"));

		public IWebElement DeleteAccountButton => _driver.FindElement(By.CssSelector(".btn.btn-danger"));

		public void DeleteAccount(string password)
		{
			PasswordInput.SendKeys(password);
			DeleteAccountButton.Click();
		}
	}
}
