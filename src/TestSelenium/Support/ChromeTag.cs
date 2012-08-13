using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using TestSelenium.Support;

namespace TestSelenium.Support
{
    [Binding]
    public class ChromeTag
    {
        [BeforeScenario("chrome")]
        public static void StartBrowser()
        {
            Contexto.Driver = new ChromeDriver();
        }

        [AfterScenario("chrome")]
        public static void StopBrowser()
        {
            if (Contexto.Driver != null)
            {
                Contexto.Driver.Close();
                Contexto.Driver.Dispose();
            }
        }

    }
}