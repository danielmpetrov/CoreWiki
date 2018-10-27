using CoreWiki.Test.E2E.Pages.Account.Manage;
using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages
{
	public class ArticleDetailsAuthenticated
	{
		private readonly IWebDriver _driver;

		public ArticleDetailsAuthenticated(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement ManageAccountLink => _driver.FindElement(By.XPath(@"//*[@id=""navbarToggler""]/ul[2]/li[2]/a"));

		public IWebElement EditLink => _driver.FindElement(By.LinkText("Edit"));

		public IWebElement DisplayNameInput => _driver.FindElement(By.Id("DisplayName"));

		public IWebElement EmailInput => _driver.FindElement(By.Id("Email"));

		public AccountManagePage GoToAccountManage()
		{
			ManageAccountLink.Click();

			return new AccountManagePage(_driver);
		}

		public EditArticlePage GoToEditArticlePage()
		{
			EditLink.Click();

			return new EditArticlePage(_driver);
		}
	}
}
