using CoreWiki.Test.E2E.Pages;
using Xunit;

namespace CoreWiki.Test.E2E
{
	public class AccountCreationTests : BaseSeleniumTest
	{
		[Fact]
		public void CanRegisterAndDeleteAccount()
		{
			const string email = "automation@corewiki.test.com";
			const string password = "P@ssw0rd";

			new HomePageAnonymous(_driver)
				.HavigateToSelf()
				.GoToRegisterPage()
				.Register(email, password)
				.GoToAccountManage()
				.GoToPersonalData()
				.GoToDeletePersonalData()
				.DeleteAccount(password);
		}
	}
}
