namespace rw.by
{
	internal static class XPathRw
	{
		//HomePage 
		internal const string INPUT_DEPARTURE_STATION = "//input[@id='acFrom']",
							INPUT_DESTINATION_STATION = "//input[@id='acTo']",
							INPUT_DATE_OF_TRAVEL = "//input[@id='yDate']",
							CONFIRM_SELECTION = "//span[@class='std-button']",
							ONLINE_SCHEDULE = "//a[@class='head icon-4']",
							TIMETABLE = "//a[@class='head icon-6']",
							SALES_POINTS = "//a[@class='head icon-3']";


		//CALENDAR
		internal const string CALENDAR = "//a[@class='calendar']",
							CHOOSE_CURRENT_MONTH = "//div[@class='ui-datepicker-group ui-datepicker-group-first']",
							CHOOSE_NEXT_MONTH = "//div[@class='ui-datepicker-group ui-datepicker-group-middle']",
							CHOOSE_NEXT_AFTER_NEXT_MONTH = "//div[@class='ui-datepicker-group ui-datepicker-group-last']",
							CHOOSE_TODAY = "//a[@date-code='today']",
							CHOOSE_TOMORROW = "//a[@date-code='tomorrow']",
							CHOOSE_ALL_DAY = "//a[@date-code='everyday']";

		//TrainsListPage
		internal const string CHOOSE_TRAIN_BY_DEPARTURE = "//a[@href='#departure-tab']",
							CHOOSE_DEPARTURE_MORNING_TRAIN = "//span[@data-filter-value='from_morning']",
							CHOOSE_DEPARTURE_AFTERNOON_TRAIN = "//span[@data-filter-value='from_aternoon']",
							CHOOSE_DEPARTURE_EVENING_TRAIN = "//span[@data-filter-value='from_evening']",
							CHOOSE_DEPARTURE_NIGHT_TRAIN = "//span[@data-filter-value='from_night']",
							CHOOSE_TRAIN_BY_ARRIVAL = "//a[@href='#arrival-tab']",


							CHOOSE_TRAIN_WITH_AVAIL_SEATS = "//span[@data-filter-value='w_places']",
							CHOOSE_TRAIN_WITH_ELECTRONIC_REGISTRATION = "//span[@data-filter-value='eregistration']",
							CHOOSE_TRAIN_WITH_PLASE_FOR_WEELCHAIR_USERS = "//span[@data-filter-value='special']",
							CHOOSE_INTERNATIONAL_TRAIN = "//span[@data-filter-value='international']",
							CHOOSE_INTERREGIONAL_BUSINESS_TRAIN = "//span[@data-filter-value='interregional_business']",
							CHOOSE_INTERREGIONAL_ECONOMY_TRAIN = "//span[@data-filter-value='interregional_economy']",
							OPEN_SELECTED_TRAIN = "//div[contains(@class,'sch-table__row-wrap') and not(contains(@style,'display: none;'))]/descendant::div[@class='sch-table__btn-wrap']",
							LIST_OF_TRAINS = "//div[@class='sch-table__body-wrap']",
							RESET_FILTERS = "//input[@class='sch-filter__reset hidden-xs hidden-sm']",

							CLOSE_ONLINE_CONSULTANT = "//div[@class='webim-invitation-header webim-custom-style-invitation-header']/child::div[@class='webim-actions']";
		
		//TrainPage
		internal const string CHOOSE_3CL = "//a[@data-car-type='3']",
							CHOOSE_2CL = "//a[@data-car-type='4']",
							CHOOSE_1CL = "//a[@data-car-type='6']",
							LIST_OF_CARS = "//div[@class='pl-accord__acc-heading']",
							FREE_SEAT_TOP = "//div[@class='carriage__seat free top H ']",
							FREE_SEAT_BOTTOM = "//div[@class='carriage__seat free bottom H ']",
							INPUT_DATA_OF_PASSENGER = "//div[@class='carriage-cost__btn-list']";


	}
}
