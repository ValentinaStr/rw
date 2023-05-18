using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace rw.by
{
	public class DriverCreation
	{
		public static DriverCreation _instance;
		internal IWebDriver _driver;
		internal WebDriverWait _wait;
		internal Actions _action;
		internal readonly LoggerService _logger;
		const int WAITTIME = 30;

		private DriverCreation()
		{
			_driver = new ChromeDriver();
			_wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(WAITTIME));
			_action = new Actions(_driver);
			_logger = LoggerService.GetLogger();
		}
	
		public static DriverCreation GetDriverAction()
		{
			_instance ??= new DriverCreation();
			return _instance;
		}
	}
}
