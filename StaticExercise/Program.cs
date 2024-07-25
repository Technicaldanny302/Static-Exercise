namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FarenheitToCelsius(68);
            var farenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"farenheit {farenheit}");
        }
    }
}
