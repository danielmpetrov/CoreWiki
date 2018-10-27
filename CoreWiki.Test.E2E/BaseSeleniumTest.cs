using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace CoreWiki.Test.E2E
{
	public abstract class BaseSeleniumTest : IDisposable
	{
		private const string _baseUrl = "https://localhost:8081/";

		protected readonly IWebDriver _driver;

		public BaseSeleniumTest()
		{
			_driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
			_driver.Manage().Window.FullScreen();
			_driver.Navigate().GoToUrl(_baseUrl);
		}

		public void Dispose()
		{
			_driver.Quit();
		}
	}
}
