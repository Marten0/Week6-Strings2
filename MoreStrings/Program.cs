using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsinaale

            Console.WriteLine("Sisesta oma eesnimi:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string Lastname = Console.ReadLine();

            Console.WriteLine($"Tere, {Firstname[0]}. {Lastname[0]}.");
        }
    }
}
