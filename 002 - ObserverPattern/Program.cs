using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays 

            //DONE:
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);


            //testdata:
            weatherData.SetMeasurements(28, 65, 30.4f);
            weatherData.SetMeasurements(29, 70, 29.2f);
            weatherData.SetMeasurements(30, 90, 29.2f);

            weatherData.RemoveObserver(statisticsDisplay);

            weatherData.SetMeasurements(13, 85, 28.5f);

            weatherData.RegisterObserver(statisticsDisplay);

            weatherData.SetMeasurements(32, 50, 28.7f);


        }
    }
}