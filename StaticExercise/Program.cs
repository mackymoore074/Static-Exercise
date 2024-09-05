namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Celcius = TemperatureConverter.FahrenheitToCelsius(64);
            var Fahrenheit = TemperatureConverter.CelsiusToFahrenheit(18);

            Console.WriteLine($" Celcius {Celcius}");
            Console.WriteLine($" Fahrenheit {Fahrenheit}");

        }
    }
}
