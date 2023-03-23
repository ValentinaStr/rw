using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace rw.by
{
	internal class Program
	{
		static void Main(string[] args)
		{
			WebDriver driver = new ChromeDriver();

			HomePage home = new HomePage(driver);
			home.InputDepartureStation("Минск");
			home.InputDestinationStation("Брест");
			home.ChooseDayNextAfterNextMonth("100");
			//home.InputDateOfTravel("25.03.2023");
			TrainsList listOfTrain =  home.СonfirmSelection();
			Thread.Sleep(1000);
			listOfTrain.СhooseEveningTrain();
			listOfTrain.CloseOnlineConsultant();
			driver.Close();
			Console.WriteLine("END");


		}
	}
}