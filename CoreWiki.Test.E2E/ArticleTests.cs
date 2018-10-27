using CoreWiki.Test.E2E.Pages;
using Xunit;

namespace CoreWiki.Test.E2E
{
	public class ArticleTests : BaseSeleniumTest
	{
		const string _defaultAdminEmail = "admin@corewiki.com";
		const string _defaultAdminPassword = "Admin@123";
		private readonly ArticleDetailsAuthenticated _homePageAuthenticated;

		public ArticleTests()
		{
			_homePageAuthenticated = new ArticleDetailsAnonymous(_driver)
				.GoToLoginPage()
				.Login(_defaultAdminEmail, _defaultAdminPassword);
		}

		[Fact]
		public void AdminShouldBeAbleToEditArticle()
		{
			_homePageAuthenticated
				.GoToEditArticlePage()
				.UpdateArticle("Hello Automation", "Brand new content!");

			Assert.Equal("Hello Automation - CoreWiki", _driver.Title);
		}
	}
}
