﻿using OpenQA.Selenium;
using System.Text;

namespace rw.by
{
	public class TrainsListPage : BasePage
	{
		
		public IWebElement ListOfTrain { get; private set; }

		public TrainsListPage(IWebDriver driver) : base(driver)
		{
		}

		public void CHooseTrainWithAvailableSeats()
		{
			try { FindElementWhithWaiter(XPathRw.CHOOSE_TRAIN_WITH_AVAIL_SEATS).Click(); }
			catch { CloseOnlineConsultant(); }
		}
		public void CHooseTrainWithElectronicRegistration()
		{
			FindElementWhithWaiter(XPathRw.CHOOSE_TRAIN_WITH_ELECTRONIC_REGISTRATION).Click();
		}
		public void CHooseTrainWithPlacesForWheelchairUsers()
		{
			FindElementWhithWaiter(XPathRw.CHOOSE_TRAIN_WITH_PLASE_FOR_WEELCHAIR_USERS).Click();
		}

		public void СhooseMorningTrain()
		{
			try { SkrolToElementAndClick(XPathRw.CHOOSE_MORNING_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseAfternoonTrain()
		{
			try { SkrolToElementAndClick(XPathRw.CHOOSE_AFTERNOON_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseEveningTrain()
		{
			try { SkrolToElementAndClick(XPathRw.CHOOSE_EVENING_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseNightTrain()
		{
			try { SkrolToElementAndClick(XPathRw.CHOOSE_NIGHT_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}
		public void СhooseInternationalTrain()
		{
			try { SkrolToElementAndClick(XPathRw.CHOOSE_INTERNATIONAL_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseBusinesTrain()
		{
			try { SkrolToElementAndClick(XPathRw.CHOOSE_INTERREGIONAL_BUSINESS_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseEconomyTrain()
		{
			try { SkrolToElementAndClick(XPathRw.CHOOSE_INTERREGIONAL_ECONOMY_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}
		public void ConsoleWriteListOfTrains()
		{
			Console.OutputEncoding = Encoding.UTF8;
			ListOfTrain = FindElementWhithWaiter(XPathRw.LIST_OF_TRAINS);
			Console.WriteLine(ListOfTrain.Text);
		}

		public TrainPage OpenSelectedTrainToChooseTicket(int numberTrain)
		{
			
			List<IWebElement> listSelectedTrain = _driver.FindElements(By.XPath(XPathRw.OPEN_SELECTED_TRAIN)).ToList();
			try	{ listSelectedTrain[numberTrain].Click(); }
			catch { Console.WriteLine("Your route could not be found for your parameters"); }
			return new TrainPage(_driver);
		}

		public void ResetFilters()
		{
			SkrolToElementAndClick(XPathRw.RESET_FILTERS);
		}
	}	
}
