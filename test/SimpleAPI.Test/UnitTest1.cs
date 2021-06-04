using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController weatherForecast = new WeatherForecastController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = weatherForecast.Get(1);
            Assert.Equal("Amir", returnValue.Value);
        }
    }
}
