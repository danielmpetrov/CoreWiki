using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace CoreWiki.Test.E2E.Support
{
	// The reason for having this wrapper class is that
	// using SendKeys on the underlying textarea directly results in an ElementNotVisibleException.
	// This is because EasyMde is wrapping it in custom elements.
	public class EasyMdeEditor
	{
		private readonly IWebDriver _driver;

		private readonly IWebElement _webElement;

		public EasyMdeEditor(IWebDriver driver)
		{
			_driver = driver;
			_webElement = _driver.FindElement(By.ClassName("CodeMirror-line"));
		}

		public void Clear()
		{
			_webElement.Click();
			var actions = new Actions(_driver);
			for (var i = 0; i < "This is the default home page. Please change me!".Length; i++)
			{
				actions.SendKeys(Keys.Backspace);
			}
			actions.Perform();
		}

		public void SendKeys(string text)
		{
			_webElement.Click();
			new Actions(_driver).SendKeys(text).Perform();
		}
	}
}
