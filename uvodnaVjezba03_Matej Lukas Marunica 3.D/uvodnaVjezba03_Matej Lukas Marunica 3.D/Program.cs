using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba03_Matej_Lukas_Marunica_3.D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c;
            natrag:
            Console.Write("Unesi dužinu a stranicu ---> ");
            a = int.Parse(Console.ReadLine());
            if (a < 1)
            {
                Console.Write("Unesi dužinu a stranicu ponovno");
                Console.WriteLine();
                a = 0;
                goto natrag;
            }
            Console.Write("Unesi dužinu b stranicu ---> ");
            b = int.Parse(Console.ReadLine());
            if (b < 1)
            {
                Console.Write("Unesi dužinu b stranicu ponovno");
               Console.WriteLine();
                b = 0;
                goto natrag;
            }

            c = Math.Sqrt((a*a)+(b*b));
            c = Convert.ToInt32(c);

            Console.WriteLine(" a stranica iznosi: " + a + " b stranica iznosi: " + b + " a hipotenuza odnosno c stranica iznosi: " + c);
            Console.ReadKey();
        }
    }
}
