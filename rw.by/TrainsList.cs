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
			SkrolToElement(XPathRw.CHOOSE_MORNING);
		}

		public void СhooseAfternoonTrain()
		{
			SkrolToElement(XPathRw.CHOOSE_AFTERNOON);
		}

		public void СhooseEveningTrain()
		{
			SkrolToElement(XPathRw.CHOOSE_EVENING);
		}

		public void СhooseNightTrain()
		{
			SkrolToElement(XPathRw.CHOOSE_NIGHT);
		}
	}
}
