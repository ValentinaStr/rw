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

		//TrainsListPage
		internal const string CHOOSE_MORNING_TRAIN = "//span[@data-filter-value='from_morning']";
		internal const string CHOOSE_AFTERNOON_TRAIN = "//span[@data-filter-value='from_aternoon']";
		internal const string CHOOSE_EVENING_TRAIN = "//span[@data-filter-value='from_evening']";
		internal const string CHOOSE_NIGHT_TRAIN = "//span[@data-filter-value='from_night']";
		internal const string CHOOSE_TRAIN_WITH_AVAIL_SEATS = "//span[@data-filter-value='w_places']";
		internal const string CHOOSE_TRAIN_WITH_ELECTRONIC_REGISTRATION = "//span[@data-filter-value='eregistration']";
		internal const string CHOOSE_TRAIN_WITH_PLASE_FOR_WEELCHAIR_USERS = "//span[@data-filter-value='special']";
		internal const string CHOOSE_INTERNATIONAL_TRAIN = "//span[@data-filter-value='international']";
		internal const string CHOOSE_INTERREGIONAL_BUSINESS_TRAIN = "//span[@data-filter-value='interregional_business']";
		internal const string CHOOSE_INTERREGIONAL_ECONOMY_TRAIN = "//span[@data-filter-value='interregional_economy']";
		internal const string OPEN_SELECTED_TRAIN = "//div[contains(@class,'sch-table__row-wrap') and not(contains(@style,'display: none;'))]/descendant::div[@class='sch-table__btn-wrap']";
		internal const string LIST_OF_TRAINS = "//div[@class='sch-table__body-wrap']"; 
		internal const string RESET_FILTERS = "//input[@class='sch-filter__reset hidden-xs hidden-sm']";

		internal const string CLOSE_ONLINE_CONSULTANT = "//div[@class='webim-invitation-header webim-custom-style-invitation-header']/child::div[@class='webim-actions']";
		
		//TrainPage
		internal const string CHOOSE_3CL = "//a[@data-car-type='3']";
		internal const string CHOOSE_2CL = "//a[@data-car-type='4']";
		internal const string CHOOSE_1CL = "//a[@data-car-type='6']";
		internal const string LIST_OF_CARS = "//div[@class='pl-accord__acc-heading']";
		internal const string FREE_SEAT_TOP = "//div[@class='carriage__seat free top H ']";
		internal const string FREE_SEAT_BOTTOM = "//div[@class='carriage__seat free bottom H ']";
		internal const string INPUT_DATA_OF_PASSENGER = "//div[@class='carriage-cost__btn-list']";


	}
}
