using System;

namespace Vsite.CSharp
{
    public class DosegImena
    {
        static void Main(string[] args)
        {
            DosegImena p = new DosegImena();
            p.IspišiAove();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public void IspišiAove()
        {
            string a = "Lokalna varijabla";

            // Ispisati vrijednosti lokalne varijable a
            Console.WriteLine(a);
            // Ispisati vrijednost člana klase a
            Console.WriteLine(this.a);
            {
                // NOT! TODO: Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost
                // int a = 5;
            }
        }

        string a = "Član klase";
    }
}
