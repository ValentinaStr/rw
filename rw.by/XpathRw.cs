
namespace rw.by
{
	static class XPathRw
	{
		//HomePage 
		internal const string INPUT_DEPARTURE_STATION = "//input[@id='acFrom']";
		internal const string INPUT_DESTINATION_STATION = "//input[@id='acTo']";
		internal const string INPUT_DATE_OF_TRAVEL = "//input[@id='yDate']";
		internal const string CONFIRM_SELECTION = "//input[@hidefocus='true']";

		//CALENDAR
		internal const string CALENDAR = "//a[@class='calendar']";
		internal const string CHOOSE_CURRENT_MONTH = "//div[@class='ui-datepicker-group ui-datepicker-group-first']";
		internal const string CHOOSE_NEXT_MONTH = "//div[@class='ui-datepicker-group ui-datepicker-group-middle']";
		internal const string CHOOSE_NEXT_AFTER_NEXT_MONTH = "//div[@class='ui-datepicker-group ui-datepicker-group-last']";
		internal const string CHOOSE_TODAY = "//a[@date-code='today']";
		internal const string CHOOSE_TOMORROW = "//a[@date-code='tomorrow']";
		internal const string CHOOSE_ALL_DAY = "//a[@date-code='everyday']";
		
		//TrainsList
		internal const string CHOOSE_MORNING = "//span[@data-filter-value='from_morning']";
		internal const string CHOOSE_AFTERNOON = "//span[@data-filter-value='from_aternoon']";
		internal const string CHOOSE_EVENING = "//span[@data-filter-value='from_evening']";
		internal const string CHOOSE_NIGHT = "//span[@data-filter-value='from_night']";

		internal const string CLOSE_ONLINE_CONSULTANT = "//div[@class='webim-invitation-header webim-custom-style-invitation-header']/child::div[@class='webim-actions']";
	}
}
