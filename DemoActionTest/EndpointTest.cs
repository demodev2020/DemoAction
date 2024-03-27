using DemoAction;

namespace DemoActionTest;

public sealed class WeatherForecastTests
{
    [Fact]
    public void TemperatureF_ConvertsCorrectly()
    {
        var forecast = new WeatherForecast(DateOnly.FromDateTime(DateTime.Now), 0, null);
        Assert.Equal(32, forecast.TemperatureF);
    }
}