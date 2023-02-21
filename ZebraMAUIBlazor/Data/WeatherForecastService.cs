using CommunityToolkit.Mvvm.Messaging;

namespace ZebraMAUIBlazor.Data;

public class WeatherForecastService
{

	static String message = "";
	public WeatherForecastService()
	{
		WeakReferenceMessenger.Default.Register<string>(this, (r, m) =>
		{
			message = m;
		});
	}
	private static readonly string[] Summaries = new[]
	{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};



	public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
	{
		return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
		{
			Date = startDate.AddDays(index),
			TemperatureC = Random.Shared.Next(-20, 55),
			Summary = Summaries[Random.Shared.Next(Summaries.Length)],
			Message = message
		}).ToArray());
	}
}

