using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            return nizRiječi.Contains(tražena);
            //foreach (string riječ in nizRiječi)
            //{
            //    if (riječ == tražena)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            //int zbroj = 0;
            //foreach(int broj in brojevi)
            //{
            //    zbroj += zbroj;
            //}
            //return zbroj;

            return brojevi.Sum();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> riječi, string riječ)
        {
            return riječi.Where(r => r.CompareTo(riječ) > 0);
        }
    }
}
