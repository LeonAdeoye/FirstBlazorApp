namespace FirstBlazorApp
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]?> GetWeatherForecast();
    }
}
