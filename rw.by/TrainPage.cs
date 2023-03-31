using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Text;

namespace rw.by
{
	public class TrainPage : BasePage
	{
		public TrainPage(IWebDriver driver) : base(driver)
		{

		}
		public void Choose3ClCar ()
		{
			FindElementWhithWaiter(XPathRw.CHOOSE_3CL).Click();
		}
		public void Choose2ClCar()
		{
			FindElementWhithWaiter(XPathRw.CHOOSE_2CL).Click();
		}
		public void Choose1ClCar()
		{
			FindElementWhithWaiter(XPathRw.CHOOSE_1CL).Click();
		}

		public void WriteFreeSeatsForTheSelectedCar(int number)
		{
			Thread.Sleep(1000);
			List<IWebElement> listCars = FindElementsWhithWaiter(XPathRw.LIST_OF_CARS).ToList();
			if (number < listCars.Count)
			{
				Console.OutputEncoding = Encoding.UTF8;
				Console.WriteLine(listCars[number].Text);
			}
			else
			{
				Console.WriteLine("Your car could not be found for your parameters") ;
			}
		}

		public void ChooseCarFoTravel()
		{
			try
			{
				List<IWebElement> listCars = FindElementsWhithWaiter(XPathRw.LIST_OF_CARS).ToList();
				listCars[0].Click();
			}
			catch { CloseOnlineConsultant(); }
		}

		public void ChooseSeatBottom()
		{
			Thread.Sleep(3000);
			SkrolToElement(XPathRw.FREE_SEAT_BOTTOM);
			List<IWebElement> listSeats = FindElementsWhithWaiter(XPathRw.FREE_SEAT_BOTTOM).ToList();
			try { listSeats[0].Click(); }
			catch { Console.WriteLine("Your seat could not be found for your parameters"); }
		}

		public void ChooseSeatTop()
		{
			Thread.Sleep(3000);
			SkrolToElement(XPathRw.FREE_SEAT_TOP);
			List<IWebElement> listSeats = FindElementsWhithWaiter(XPathRw.FREE_SEAT_TOP).ToList();
			try { listSeats[0].Click(); }
			catch { Console.WriteLine("Your seat could not be found for your parameters"); }
		}

		public void ClickButtonInputDataOfPassager()
		{ 
			FindElementWhithWaiter(XPathRw.INPUT_DATA_OF_PASSENGER).Click();
		}
	}
}
