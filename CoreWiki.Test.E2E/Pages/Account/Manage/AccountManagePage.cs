using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages.Account.Manage
{
	public class AccountManagePage
	{
		private readonly IWebDriver _driver;

		public AccountManagePage(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement PersonalDataLink => _driver.FindElement(By.LinkText("Personal data"));

		public PersonalDataPage GoToPersonalData()
		{
			PersonalDataLink.Click();

			return new PersonalDataPage(_driver);
		}
	}
}
