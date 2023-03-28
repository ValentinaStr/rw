using OpenQA.Selenium;
using System.Collections.ObjectModel;
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
			FindElementWhithWaiter(XPathRw.CHOOSE_TRAIN_WITH_AVAIL_SEATS).Click();
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
			try { SkrolToElement(XPathRw.CHOOSE_MORNING_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseAfternoonTrain()
		{
			try { SkrolToElement(XPathRw.CHOOSE_AFTERNOON_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseEveningTrain()
		{
			try { SkrolToElement(XPathRw.CHOOSE_EVENING_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseNightTrain()
		{
			try { SkrolToElement(XPathRw.CHOOSE_NIGHT_TRAIN); }
			catch { CloseOnlineConsultant(); }
		}

		public void PrintListOfTrains()
		{
			Console.OutputEncoding = Encoding.UTF8;
			ListOfTrain = FindElementWhithWaiter(XPathRw.LIST_OF_TRAINS);
			Console.Write(ListOfTrain.Text);
		}
	}
}
