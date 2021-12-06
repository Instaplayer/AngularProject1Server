using WebApplication1.Controllers;
using Xunit;

namespace WebApplication1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            WeatherForecastController test = new WeatherForecastController(null);
            
            Assert.NotNull(test);
        }
    }
}