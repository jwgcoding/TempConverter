// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using StaticExcercise;


namespace StaticExcercise
{
    public class Program
    {
       static void Main(string[] args)
        {
           var celsius =TempConverter.FahrenheitToCelsius(90);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"celsius : {celsius}");
            Console.WriteLine($"fahrenheit : {fahrenheit}");
        }
    }
}
