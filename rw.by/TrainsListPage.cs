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
			try { FindElementWhithWaiter(CHOOSE_TRAIN_WITH_AVAIL_SEATS).Click(); }
			catch { CloseOnlineConsultant(); }
		}
		public void ChooseTrainWithElectronicRegistration()
		{
			FindElementWhithWaiter(CHOOSE_TRAIN_WITH_ELECTRONIC_REGISTRATION).Click();
		}
		public void ChooseTrainWithPlacesForWheelchairUsers()
		{
			FindElementWhithWaiter(CHOOSE_TRAIN_WITH_PLASE_FOR_WEELCHAIR_USERS).Click();
		}
		public void ChooseTrainByArrival()
		{
			FindElementWhithWaiter(CHOOSE_TRAIN_BY_ARRIVAL).Click();
		}

		public void ChooseMorningTrain()
		{
			try { SkrolToElementAndClick(CHOOSE_DEPARTURE_MORNING_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseAfternoonTrain()
		{
			try { SkrolToElementAndClick(CHOOSE_DEPARTURE_AFTERNOON_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseEveningTrain()
		{
			try { SkrolToElementAndClick(CHOOSE_DEPARTURE_EVENING_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseNightTrain()
		{
			try { SkrolToElementAndClick(CHOOSE_DEPARTURE_NIGHT_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}
		public void СhooseInternationalTrain()
		{
			try { SkrolToElementAndClick(CHOOSE_INTERNATIONAL_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseBusinesTrain()
		{
			try { SkrolToElementAndClick(CHOOSE_INTERREGIONAL_BUSINESS_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseEconomyTrain()
		{
			try { SkrolToElementAndClick(CHOOSE_INTERREGIONAL_ECONOMY_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}
		public void ConsoleWriteListOfTrains()
		{
			Console.OutputEncoding = Encoding.UTF8;
			ListOfTrain = FindElementWhithWaiter(LIST_OF_TRAINS);
			Console.WriteLine(ListOfTrain.Text);
		}

		public TrainPage OpenSelectedTrainToChooseTicket(int numberTrain)
		{
			
			List<IWebElement> listSelectedTrain = _driver.FindElements(By.XPath(OPEN_SELECTED_TRAIN)).ToList();
			try	{ listSelectedTrain[numberTrain].Click(); }
			catch {_ =  _logger.WriteLog("Your route could not be found for your parameters"); }
			return new TrainPage(_driver, _logger);
		}

		public void ResetFilters()
		{
			SkrolToElementAndClick(RESET_FILTERS);
		}
	}	
}
