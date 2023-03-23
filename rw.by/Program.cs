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
			home.InputDestinationStation("Молодечно");
			home.ChooseTomorrow();
			//home.ChooseDayCurrentMonth("28");
			//home.InputDateOfTravel("25.03.2023");
			TrainsList listOfTrain =  home.СonfirmSelection();
			Thread.Sleep(1000);
			listOfTrain.СhooseEveningTrain();
			driver.Close();
			
		}
	}
}