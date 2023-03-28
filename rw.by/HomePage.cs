using OpenQA.Selenium;

namespace rw.by
{
	public class HomePage : BasePage
	{
		public HomePage(IWebDriver driver) : base(driver)
		{
			GoToUrl("https://www.rw.by/");
		}

		public void InputDepartureStation(string nameStation)
		{
			_driver.FindElement(By.XPath(XPathRw.INPUT_DEPARTURE_STATION)).SendKeys(nameStation);
		}
		public void InputDestinationStation(string nameStation)
		{
			_driver.FindElement(By.XPath(XPathRw.INPUT_DESTINATION_STATION)).SendKeys(nameStation);
		}
		public void InputDateOfTravel(string dateOfTravel)
		{
			_driver.FindElement(By.XPath(XPathRw.INPUT_DATE_OF_TRAVEL)).SendKeys(dateOfTravel);
			_driver.FindElement(By.XPath(XPathRw.INPUT_DATE_OF_TRAVEL)).SendKeys(Keys.Enter);
		}
		public TrainsListPage СonfirmSelection()
		{
			_driver.FindElement(By.XPath(XPathRw.CONFIRM_SELECTION)).Click();
			return new TrainsListPage(_driver);
		}
		public void OpenCalendar()
		{
			_driver.FindElement(By.XPath(XPathRw.CALENDAR)).Click();
		}

		public void ChooseToday()
		{
			_driver.FindElement(By.XPath(XPathRw.CHOOSE_TODAY)).Click();
		}

		public void ChooseTomorrow()
		{
			_driver.FindElement(By.XPath(XPathRw.CHOOSE_TOMORROW)).Click();
		}

		public void ChooseAllDays()
		{
			_driver.FindElement(By.XPath(XPathRw.CHOOSE_ALL_DAY)).Click();
		}
		public void ChooseDayCurrentMonth(string day)
		{ 
			OpenCalendar();
			try { _driver.FindElement(By.XPath(XPathRw.CHOOSE_CURRENT_MONTH + "//a[text()='" + day + "']")).Click(); }
			catch (Exception) { Console.WriteLine("Wrong date"); }
		}
		public void ChooseDayNextMonth(string day)
		{
			OpenCalendar();
			try { _driver.FindElement(By.XPath(XPathRw.CHOOSE_NEXT_MONTH + "//a[text()='" + day + "']")).Click(); }
			catch (Exception) { Console.WriteLine("Wrong date"); }
		}
		public void ChooseDayNextAfterNextMonth(string day)
		{
			OpenCalendar();
			try { _driver.FindElement(By.XPath(XPathRw.CHOOSE_NEXT_AFTER_NEXT_MONTH + "//a[text()='" + day + "']")).Click(); }
			catch (Exception) { Console.WriteLine("Wrong date"); }
		}
	}
}
