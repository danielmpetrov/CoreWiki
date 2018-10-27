using System;
using CoreWiki.Test.E2E.Pages.Account.Manage;
using CoreWiki.Test.E2E.Support;
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

		public EasyMdeEditor CommentContentEditor => new EasyMdeEditor(_driver);

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

		public void PostComment(string displayName, string email, string content)
		{
			DisplayNameInput.SendKeys(displayName);
			EmailInput.SendKeys(email);
			CommentContentEditor.SendKeys(content);
			DisplayNameInput.Submit();
		}
	}
}
