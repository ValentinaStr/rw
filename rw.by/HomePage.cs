using OpenQA.Selenium;
using static rw.by.XPathRw;

namespace rw.by
{
	public class HomePage : BasePage
	{
		public HomePage(IWebDriver driver, LoggerService logger) : base(driver, logger)
		{
			GoToUrl("https://www.rw.by/");
		}

		public void InputDepartureStation(string nameStation)
		{
			FindElementWithWaiter(INPUT_DEPARTURE_STATION).SendKeys(nameStation);
		}
		public void InputDestinationStation(string nameStation)
		{
			FindElementWithWaiter(INPUT_DESTINATION_STATION).SendKeys(nameStation);
		}
		public void InputDateOfTravel(string dateOfTravel)
		{
			FindElementWithWaiter(INPUT_DATE_OF_TRAVEL).SendKeys(dateOfTravel);
			FindElementWithWaiter(INPUT_DATE_OF_TRAVEL).SendKeys(Keys.Enter);
		}

		public void OpenCalendar()
		{
			FindElementWithWaiter(CALENDAR).Click();
		}
		public void ChooseToday()
		{
			FindElementWithWaiter(CHOOSE_TODAY).Click();
		}

		public void ChooseTomorrow()
		{
			FindElementWithWaiter(CHOOSE_TOMORROW).Click();
		}

		public void ChooseAllDays()
		{
			FindElementWithWaiter(CHOOSE_ALL_DAY).Click();
		}
		public void ChooseDayCurrentMonth(string day)
		{ 
			OpenCalendar();
			try { FindElementWithWaiter(CHOOSE_CURRENT_MONTH + "//a[text()='" + day + "']").Click(); }
			catch (Exception) { _ = _logger.WriteLogAsync("Wrong date"); }
		}

		public void ChooseDayNextMonth(string day)
		{
			OpenCalendar();
			try { FindElementWithWaiter(CHOOSE_NEXT_MONTH + "//a[text()='" + day + "']").Click(); }
			catch (Exception) { _ = _logger.WriteLogAsync("Wrong date"); }
		}

		public void ChooseDayNextAfterNextMonth(string day)
		{
			OpenCalendar();
			try { FindElementWithWaiter(CHOOSE_NEXT_AFTER_NEXT_MONTH + "//a[text()='" + day + "']").Click(); }
			catch (Exception) { _ = _logger.WriteLogAsync("Wrong date"); }
		}

		public TrainsListPage ConfirmSelectionOpenListOfTrains()
		{
			FindElementWithWaiter(CONFIRM_SELECTION).Click();
			return new TrainsListPage(_driver, _logger);
		}

		public OnlineSchedulePage OpenOnlineSchedule()
		{
			FindElementWithWaiter(ONLINE_SCHEDULE).Click();
			return new OnlineSchedulePage(_driver, _logger);
		}

		public TimetablePage OpenTimetable()
		{
			FindElementWithWaiter(TIMETABLE).Click();
			return new TimetablePage(_driver, _logger);
		}
		public SalesPointsPage OpenSalesPoints()
		{
			FindElementWithWaiter(SALES_POINTS).Click();
			return new SalesPointsPage(_driver, _logger);
		}
	}
}
