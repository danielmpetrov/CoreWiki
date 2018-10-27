using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages.Account.Manage
{
	public class PersonalDataPage
	{
		private IWebDriver _driver;

		public PersonalDataPage(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement DeleteLink => _driver.FindElement(By.LinkText("Delete"));

		public DeletePersonalDataPage GoToDeletePersonalData()
		{
			DeleteLink.Click();

			return new DeletePersonalDataPage(_driver);
		}
	}
}
