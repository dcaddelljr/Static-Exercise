using StaticExercise;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Celsius temperature: ");
            var userInput1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The converted Celsius temperature is  {TempConverter.CelsiusToFahrenheit(userInput1)} Fahrenheit");
            Console.WriteLine();

            Console.WriteLine("Enter a Fahrenheit temperature: ");
            var userInput2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The converted Fahrenheit temperature is  {TempConverter.FahrenheitToCelsius(userInput2)} Celsius");
        }
    }
}


