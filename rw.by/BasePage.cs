using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace rw.by
{
	public abstract class BasePage
	{
		protected IWebDriver _driver;
		protected WebDriverWait _wait;
		protected Actions _action;
		protected readonly LoggerService _logger;
		const int WAITTIME = 30;

		public BasePage(IWebDriver driver, LoggerService logger)
		{
			_driver = driver;
			_wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(WAITTIME));
			_action = new Actions(_driver);
			_logger = logger;
		}

		protected void GoToUrl(string url)
		{
			_driver.Url = url;
			_driver.Manage().Window.Maximize();
		}

		protected void SkrolToElementAndClick(string xPath)
		{
			_wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
			_action.MoveToElement(_driver.FindElement(By.XPath(xPath)));
			_action.Perform();
			_driver.FindElement(By.XPath(xPath)).Click();
		}
		protected void SkrolToElement(string xPath)
		{
			_wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
			_action.MoveToElement(_driver.FindElement(By.XPath(xPath)));
			_action.Perform();
		}

		protected IWebElement FindElementWhithWaiter(string xpath)
		{
			return _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
		}

		protected  ReadOnlyCollection<IWebElement> FindElementsWhithWaiter(string xpath)
		{
			return _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(xpath)));
		}

		protected void CloseOnlineConsultant()
		{
			_driver.FindElement(By.XPath(XPathRw.CLOSE_ONLINE_CONSULTANT)).Click();
		}

	}
}
