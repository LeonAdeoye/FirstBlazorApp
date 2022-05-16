using System.Net.Http.Json;

namespace FirstBlazorApp
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient client = new();
        public async Task<WeatherForecast[]?> GetWeatherForecast()
        {
            // TODO fix issue with JSON file load.
            WeatherForecast[]? result = await client.GetFromJsonAsync<WeatherForecast[]?>("weather.json");
            return result;
        }
    }
}
