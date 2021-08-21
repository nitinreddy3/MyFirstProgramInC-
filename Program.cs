using System;
using MyUtilities;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go next May?");
            WeatherUtilities.Report("Pune", 33, 65 );
            WeatherUtilities.Report("SF", 65, 73);
            WeatherUtilities.Report("Delhi", 75, 43);
        }
    }
}
