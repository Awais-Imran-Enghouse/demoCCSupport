using ConsoleApp1;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demoCCSupport
{
    internal class setUp
    {
        //IWebDriver driver = new ChromeDriver();

        [BeforeFeature("browser")]
        public void Initialize()
        {
            propertiesCollection.driver = new ChromeDriver();
            Console.WriteLine("Open browser");
        }

        [AfterFeature("browser")]
        public void CleanUp()
        {
            propertiesCollection.driver.Quit();
            Console.WriteLine("Quit the browser");
        }


    }
}

