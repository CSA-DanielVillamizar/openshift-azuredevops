using Microsoft.VisualStudio.TestTools.UnitTesting;
using openshiftapplication.Controllers;
using System.Linq;

namespace openshiftapplicationtest
{
    [TestClass]
    public class WeatherForecastTests
    {
        [TestMethod]
        public void TestMethodGet()
        {
            var result = WeatherForecastController.GetWeatherForecast();

            Assert.AreEqual(5, result.Count());
        }
    }
}
