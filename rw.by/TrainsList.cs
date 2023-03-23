using OpenQA.Selenium;

namespace rw.by
{
	public class TrainsList : BasePage
	{
		public TrainsList(IWebDriver driver) : base(driver)
		{
		}

		public void СhooseMorningTrain()
		{
			try { SkrolToElement(XPathRw.CHOOSE_MORNING); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseAfternoonTrain()
		{
			try { SkrolToElement(XPathRw.CHOOSE_AFTERNOON); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseEveningTrain()
		{
			try { SkrolToElement(XPathRw.CHOOSE_EVENING); }
			catch { CloseOnlineConsultant(); }
		}

		public void СhooseNightTrain()
		{
			try { SkrolToElement(XPathRw.CHOOSE_NIGHT); }
			catch { CloseOnlineConsultant(); }
		}
	}
}
