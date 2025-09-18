using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        {
            // Set the field and register itself with the weatherdata subject

            //DONE: same as rest
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters

            //DONE: first add the new temp to the sum
            sumTemperature += temp;
            countUpdated++;

            //kijk of nieuwe temp meer is dan vorige max
            if (temp > maxTemp)
                maxTemp = temp;

            //kijk of oude temp midner is dan vorige min
            if (temp < minTemp)
                minTemp = temp;

            Display();
        }

        public void Display()
        {
            // Print the average, maximum and minimum temperature. Use appropriate fields
            float averageTemp = sumTemperature / countUpdated;
            Console.WriteLine("averageTemp: " + averageTemp.ToString());
            Console.WriteLine("MaxTemp: " + maxTemp);
            Console.WriteLine("MaxTemp: " + minTemp);
        }
    }
}