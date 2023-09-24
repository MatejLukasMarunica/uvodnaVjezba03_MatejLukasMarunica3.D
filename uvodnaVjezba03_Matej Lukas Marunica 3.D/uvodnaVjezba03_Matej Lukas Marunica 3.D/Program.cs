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
            int a, b, c;
            
            sum = 0;
           
            natrag:
            Console.Write("Unesi dužinu a stranicu ---> ");
            a = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.Write("Unesi dužinu a stranicu ponovno");
                Console.WriteLine();
                a = 0;
                goto natrag;
            }
            Console.Write("Unesi dužinu b stranicu ---> ");
            b = int.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.Write("Unesi dužinu b stranicu ponovno");
               Console.WriteLine();
                b = 0;
                goto natrag;
            }

            Console.Write("Unesi dužinu c stranice ---> ");
            c = int.Parse(Console.ReadLine()); 
            if (c <= 0)
            {
                Console.Write("Unesi dužinu c stranicu ponovno");
               Console.WriteLine();
                c = 0;
                goto natrag;
            }

            if(a > b && a > c)
            {
                double sum = Math.sqrt((b*b)+(c*c));

                    if(a == sum)
                    {
                        Console.WriteLine("Dimentije pravokutnog trokuta su ispravne");
                    } 
                else
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su nisu ispravne");
                }
            }    
            else if (b > a && b > c)
            {
                 double sum = Math.sqrt((a*a)+(c*c));

                    if(b == sum)
                    {
                        Console.WriteLine("Dimentije pravokutnog trokuta su ispravne");
                    } 
                else
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su nisu ispravne");
                }
            }
            else
            {
                double sum = Math.sqrt((a*a)+(b*b));

                    if(c == sum)
                    {
                        Console.WriteLine("Dimentije pravokutnog trokuta su ispravne");
                    } 
                else
                {
                    Console.WriteLine("Dimentije pravokutnog trokuta su nisu ispravne");
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
