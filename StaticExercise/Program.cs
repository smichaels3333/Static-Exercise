﻿namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var farhenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"farhenheit {farhenheit}");
            
        }
    }
}
