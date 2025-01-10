namespace SandBox.Api.Tests;

using Sandbox.Api.Services;

public class WeatherForecastServiceTest
{
    [Fact]
    public async Task GetForeCastReturnsAList()
    {
        var result = await WeatherForecastService.GetForeCast();
        Assert.NotNull(result);
    }
}
