using CoreWiki.Test.E2E.Support;
using OpenQA.Selenium;

namespace CoreWiki.Test.E2E.Pages
{
	public class EditArticlePage
	{
		private IWebDriver _driver;

		public EditArticlePage(IWebDriver driver)
		{
			_driver = driver;
		}

		public IWebElement ArticleTopicInput => _driver.FindElement(By.Id("Article_Topic"));
		
		public EasyMdeEditor ArticleContentEditor => new EasyMdeEditor(_driver);

		public void UpdateArticle(string topic, string content)
		{
			ArticleTopicInput.Clear();
			ArticleTopicInput.SendKeys(topic);

			ArticleContentEditor.Clear();
			ArticleContentEditor.SendKeys(content);

			ArticleTopicInput.Submit();
		}
	}
}
