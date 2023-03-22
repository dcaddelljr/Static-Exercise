using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 1.8) + 32;
        }
     
        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * .5556;
        }
    }
}

