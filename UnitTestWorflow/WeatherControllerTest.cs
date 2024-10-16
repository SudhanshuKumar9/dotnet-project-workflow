using Microsoft.Extensions.Logging;
using Moq;
using WorflowTestApp.Controllers;

namespace UnitTestWorflow
{
    public class WeatherControllerTest
    {
        private readonly WeatherForecastController weatherForecastController;
        private readonly Mock<ILogger<WeatherForecastController>> _mockLoger;
        public WeatherControllerTest()
        {
            _mockLoger = new Mock<ILogger<WeatherForecastController>>();
            weatherForecastController = new WeatherForecastController(_mockLoger.Object);
        }

        [Fact]
        public void TestGetWeatherForecastResult()
        {
            var result = weatherForecastController.Get();
            Assert.Null(result);
        }
    }
}