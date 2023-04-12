using OpenQA.Selenium;
using System.Text;
using static rw.by.XPathRw;

namespace rw.by
{
	public class TrainPage : BasePage
	{
		public TrainPage(IWebDriver driver, LoggerService logger) : base(driver, logger)
		{

		}
		public void Choose3ClCar ()
		{
			FindElementWithWaiter(CHOOSE_3CL).Click();
		}
		public void Choose2ClCar()
		{
			FindElementWithWaiter(CHOOSE_2CL).Click();
		}
		public void Choose1ClCar()
		{
			FindElementWithWaiter(CHOOSE_1CL).Click();
		}

		public void WriteFreeSeatsForTheSelectedCar(int number)
		{
			List<IWebElement> listCars = FindElementsWithWaiter(LIST_OF_CARS).ToList();
			if (number < listCars.Count)
			{
				Console.OutputEncoding = Encoding.UTF8;
				_ = _logger.WriteLog(listCars[number].Text);
			}
			else
			{
				_ = _logger.WriteLog("Your car could not be found for your parameters");
			}
		}

		public void ChooseCarFoTravel()
		{
			try
			{
				List<IWebElement> listCars = FindElementsWithWaiter(LIST_OF_CARS).ToList();
				listCars[0].Click();
			}
			catch { CloseOnlineConsultant(); }
		}

		public void ChooseSeatBottom()
		{
			ScrollToElement(FREE_SEAT_BOTTOM);
			List<IWebElement> listSeats = FindElementsWithWaiter(FREE_SEAT_BOTTOM).ToList();
			try { listSeats[0].Click(); }
			catch { _ = _logger.WriteLog("Your seat could not be found for your parameters"); }
		}

		public void ChooseSeatTop()
		{
			Thread.Sleep(3000);
			ScrollToElement(FREE_SEAT_TOP);
			List<IWebElement> listSeats = FindElementsWithWaiter(FREE_SEAT_TOP).ToList();
			try { listSeats[0].Click(); }
			catch { _ = _logger.WriteLog("Your seat could not be found for your parameters"); }
		}

		public void ClickButtonInputDataOfPassager()
		{ 
			FindElementWithWaiter(INPUT_DATA_OF_PASSENGER).Click();
		}
	}
}
