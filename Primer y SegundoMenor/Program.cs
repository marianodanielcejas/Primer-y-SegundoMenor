using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_y_SegundoMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int Menor1 = 0;
            int Menor2 = 0;
            int Bandera = 0;
            int Manipulador = 0;

            Console.Write("Ingrese un número por favor: ");
            Num = int.Parse(Console.ReadLine());

            while(Num != 0)
            {
                if(Bandera == 0)
                {
                    Menor1 = Num;
                    Bandera = 1;
                }
                else if(Bandera == 1)
                {
                    if (Num < Menor1)
                    {
                        Menor2 = Menor1;
                        Menor1 = Num;
                        Manipulador = 1;
                    }
                    else if (Manipulador == 0)
                    {
                        Menor2 = Num;
                        Manipulador = 1;
                    }
                    else if(Num > Menor1 && Num <= Menor2)
                    {
                        Menor2 = Num;
                    }
                }
                Console.Write("Ingrese un número por favor: ");
                Num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El menor 1 es {0} y El menor 2 es {1} ", Menor1, Menor2);
            Console.Read();
        }
    }
}
