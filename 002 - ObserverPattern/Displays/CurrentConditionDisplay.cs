using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public CurrentConditionDisplay(Subject weatherData) 
        {
            // Set the field and register itself with the weatherdata subject

            //DONE?: thought i should use this. as i need to register itself but not sure
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters

            //DONE: updates than displays them
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            // Print the current conditions of the weather

            //DONE:
            Console.WriteLine("Temp: " + temperature);
            Console.WriteLine("Humid: " + humidity);
        }
    }
}
