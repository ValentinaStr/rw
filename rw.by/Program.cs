using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace rw.by
{
	internal class Program
	{
		static void Main(string[] args)
		{
			WebDriver driver = new ChromeDriver();
			LoggerService logger = new LoggerService();

			HomePage home = new HomePage(driver,logger);
			home.InputDepartureStation("Минск");
			home.InputDestinationStation("Брест");
			home.ChooseTomorrow();	
			TrainsListPage listOfTrain =  home.СonfirmSelectionOpenListOfTrains();

			listOfTrain.ChooseTrainWithAvailableSeats();
			
			listOfTrain.СhooseEconomyTrain();
			listOfTrain.СhooseInternationalTrain();
			
			TrainPage train = listOfTrain.OpenSelectedTrainToChooseTicket(1);

			train.Choose2ClCar();

			train.WriteFreeSeatsForTheSelectedCar(0);

			driver.Close();

		}
	}
}