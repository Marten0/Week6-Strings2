using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib  kasutajal sisestada perekonnanime
            //programm kuvab, mitu 'a' tähte kasutaja eesnimes ja
            //perekonnanimes kokku on

            Console.WriteLine("Sisesta oma eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            int counter = 0;


            for (int i = 0; i < fullName.Length; i++)
            {
                if(fullName[i] == 'a')
                {
                    counter++;
                }
            }
            
            if(counter == 1)
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' täht.");
            }
            else
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' tähte.");
            }
        }
    }
}
