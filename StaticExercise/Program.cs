using StaticExercise;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Fahrenheit temperature: ");
            double userInput1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The converted Fahrenheit temperature is {TempConverter.FahrenheitToCelsius(userInput1)} Celsius");
            Console.WriteLine();

            Console.WriteLine("Enter a Celsius temperature: ");
            double userInput2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The converted Celsius temperature is {TempConverter.CelsiusToFahrenheit(userInput2)} Fahrenheit");
           
        }
    }
}


