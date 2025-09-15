using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        {
            // Set the field and register itself with the weatherdata subject

            //DONE: same as CurentConditionDIsplay.cs
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters

            //DONE: same as CurentConditionDisplay.cs
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            // Print a forecast message based on the current temperature and humidity

            //DONE: >:)
            if (temperature > 25 && humidity > 70)
            {
                Console.WriteLine("voorspelling: CODE ORNAGE! >:) Benauwd en mogelijk stormachtig weer.");
            }
            else if (temperature < 15 && humidity > 60)
            {
                Console.WriteLine("voorspelling: Koud en regenachtig :(");
            }
            else
            {
                Console.WriteLine("voorspelling: lekker zwemweer!");
            }
        }
    }
}
