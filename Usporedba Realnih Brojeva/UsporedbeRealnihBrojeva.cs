using System;

namespace Vsite.CSharp
{
    public class UsporedbeRealnihBrojeva
    {
        static void Main(string[] args)
        {
            double tri = 3.0;

            // provjeriti što će ispisati donje dvije usporedbe te promijeniti metodu JednakiSu tako da se dobije očekivani rezultat
            if (JednakiSu((1.0 - 1.0 / tri), (2.0 / tri)))
                Console.WriteLine("1 - 1/3 jednako je 2/3");
            else
                Console.WriteLine("1 - 1/3 nije jednako 2/3!");

            if (JednakiSu(tri * 0.1, 0.3))
                Console.WriteLine("3 * 0.1 je jednako 0.3");
            else
                Console.WriteLine("3 * 0.1 nije jednako 0.3!");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static bool JednakiSu(double broj1, double broj2)
        {
            //if(broj1 ==broj2)
            //return true;
            //double razlika = Math.Abs(broj1 - broj2);
            //double delta=Math.Max(Math.Abs(broj1),Math.Abs(broj2))*0.0000001;
            //return (razlika < delta) ;

            long l1 = BitConverter.DoubleToInt64Bits(broj1);
            long l2 = BitConverter.DoubleToInt64Bits(broj2);
            if (Math.Abs(l1 - l2) < 4)
            {
                return true;
            }
            return false;
        }
    }
}
