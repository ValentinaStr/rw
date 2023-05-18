using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace rw.by
{
	internal abstract class BasePage
	{
		public DriverCreation _driverCreation;
		public BasePage()
		{
			_driverCreation = DriverCreation.GetDriverAction();
		}

		protected void GoToUrl(string url)
		{
			_driverCreation._driver.Url = url;
			_driverCreation._driver.Manage().Window.Maximize();
		}

		protected void ScrollToElementAndClick(string xPath)
		{
			_driverCreation._wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
			_driverCreation._action.MoveToElement(_driverCreation._driver.FindElement(By.XPath(xPath)));
			_driverCreation._action.Perform();
			_driverCreation._driver.FindElement(By.XPath(xPath)).Click();
		}
		protected void ScrollToElement(string xPath)
		{
			_driverCreation._wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
			_driverCreation._action.MoveToElement(_driverCreation._driver.FindElement(By.XPath(xPath)));
			_driverCreation._action.Perform();
		}

		protected IWebElement FindElementWithWaiter(string xpath)
		{
			return _driverCreation._wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
		}

		protected  ReadOnlyCollection<IWebElement> FindElementsWithWaiter(string xpath)
		{
			return _driverCreation._wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(xpath)));
		}

		protected void CloseOnlineConsultant()
		{
			_driverCreation._driver.FindElement(By.XPath(XPathRw.CLOSE_ONLINE_CONSULTANT)).Click();
		}

		protected void LogMessage ( string message)
		{
			_driverCreation._logger.WriteLogAsync(message);
		}

		internal void CloseDriver()
		{
			_driverCreation._driver.Close();
		}

	}
}
