using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace rw.by
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HomePage home = new HomePage();
			home.InputDepartureStation("Минск-Пассажирский");
			home.InputDestinationStation("Брест");
			home.ChooseTomorrow();	
			TrainsListPage listOfTrain =  home.ConfirmSelectionOpenListOfTrains();
			
			listOfTrain.ChooseTrainWithAvailableSeats();
			
			listOfTrain.ChooseEconomyTrain();
			listOfTrain.ChooseInternationalTrain();
			
			TrainPage train = listOfTrain.OpenSelectedTrainToChooseTicket(1);

			train.Choose2ClCar();

			train.WriteFreeSeatsForTheSelectedCar(1);

			home.CloseDriver();

		}
	}
}