using System.Net.Http.Json;

namespace FirstBlazorApp
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient client = new();
        public async Task<WeatherForecast[]?> GetWeatherForecast()
        {
            WeatherForecast[]? result = await client.GetFromJsonAsync<WeatherForecast[]?>("weather.json");
            return result;
        }
    }
}
