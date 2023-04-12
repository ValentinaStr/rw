using OpenQA.Selenium;
using System.Text;
using static rw.by.XPathRw;

namespace rw.by
{
	public class TrainsListPage : BasePage
	{
		
		public IWebElement ListOfTrain { get; private set; }

		public TrainsListPage(IWebDriver driver, LoggerService logger) : base(driver, logger)
		{
		}

		public void ChooseTrainWithAvailableSeats()
		{
			try { FindElementWithWaiter(CHOOSE_TRAIN_WITH_AVAIL_SEATS).Click(); }
			catch { CloseOnlineConsultant(); }
		}
		public void ChooseTrainWithElectronicRegistration()
		{
			FindElementWithWaiter(CHOOSE_TRAIN_WITH_ELECTRONIC_REGISTRATION).Click();
		}
		public void ChooseTrainWithPlacesForWheelchairUsers()
		{
			FindElementWithWaiter(CHOOSE_TRAIN_WITH_PLASE_FOR_WEELCHAIR_USERS).Click();
		}
		public void ChooseTrainByArrival()
		{
			FindElementWithWaiter(CHOOSE_TRAIN_BY_ARRIVAL).Click();
		}

		public void ChooseMorningTrain()
		{
			try { ScrollToElementAndClick(CHOOSE_DEPARTURE_MORNING_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void ChooseAfternoonTrain()
		{
			try { ScrollToElementAndClick(CHOOSE_DEPARTURE_AFTERNOON_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void ChooseEveningTrain()
		{
			try { ScrollToElementAndClick(CHOOSE_DEPARTURE_EVENING_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void ChooseNightTrain()
		{
			try { ScrollToElementAndClick(CHOOSE_DEPARTURE_NIGHT_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}
		public void ChooseInternationalTrain()
		{
			try { ScrollToElementAndClick(CHOOSE_INTERNATIONAL_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void ChooseBusinessTrain()
		{
			try { ScrollToElementAndClick(CHOOSE_INTERREGIONAL_BUSINESS_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void ChooseEconomyTrain()
		{
			try { ScrollToElementAndClick(CHOOSE_INTERREGIONAL_ECONOMY_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}
		public void ConsoleWriteListOfTrains()
		{
			Console.OutputEncoding = Encoding.UTF8;
			ListOfTrain = FindElementWithWaiter(LIST_OF_TRAINS);
			Console.WriteLine(ListOfTrain.Text);
		}

		public TrainPage OpenSelectedTrainToChooseTicket(int numberTrain)
		{
			
			List<IWebElement> listSelectedTrain = _driver.FindElements(By.XPath(OPEN_SELECTED_TRAIN)).ToList();
			try	{ listSelectedTrain[numberTrain].Click(); }
			catch {_ =  _logger.WriteLogAsync("Your route could not be found for your parameters"); }
			return new TrainPage(_driver, _logger);
		}

		public void ResetFilters()
		{
			ScrollToElementAndClick(RESET_FILTERS);
		}
	}	
}
