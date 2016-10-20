using System;

namespace Vsite.CSharp
{
    public class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            //  Napisati petlju for koja će ispisati brojeve od 0 do (uključivo) n
            for (int i=0; i <= n; i++){
                Console.WriteLine(i);
            }
        }

        public static void PetljaWhile(int n)
        {
            // Napisati petlju while koja će ispisati brojeve od 0 do (uključivo) n
            int i = 0;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            };
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            // Prevesti program te programom ILDasm usporediti međukod gornjih metoda.
            // Kodovi koji se generiraju isto... efikasnost ostaje ista

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
