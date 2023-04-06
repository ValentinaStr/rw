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
			home.ChooseTomorrow();
			//home.ChooseDayCurrentMonth("28");
			//home.InputDateOfTravel("16.04.2023");
			TrainsListPage listOfTrain =  home.СonfirmSelectionOpenListOfTrains();

			listOfTrain.ChooseTrainWithAvailableSeats();
			//listOfTrain.CHooseTrainWithElectronicRegistration();
			//listOfTrain.CHooseTrainWithPlacesForWheelchairUsers();

			//listOfTrain.СhooseBusinesTrain();
			listOfTrain.СhooseEconomyTrain();
			listOfTrain.СhooseInternationalTrain();

			//listOfTrain.СhooseEveningTrain();
			//listOfTrain.СhooseMorningTrain();
			//listOfTrain.СhooseAfternoonTrain();
			//listOfTrain.СhooseNightTrain();
			
			TrainPage train = listOfTrain.OpenSelectedTrainToChooseTicket(1);

			train.Choose2ClCar();

			train.WriteFreeSeatsForTheSelectedCar(0);

			driver.Close();

		}
	}
}