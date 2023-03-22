using System;
namespace StaticExercise
{
	public static class TempConverter
	{ 
        public static double FahrenheitToCelsius(double fTemp) => (fTemp - 32.0) * .5556;
       

        public static double CelsiusToFahrenheit(double cTemp) => (cTemp * 1.8) + 32.0;
        
    }
}

