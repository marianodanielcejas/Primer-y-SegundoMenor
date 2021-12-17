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
            int Posición = 0;
            int PosMin1 = Posición;
            int PosMin2 = Posición;

            Console.Write("Ingrese un número por favor: ");
            Num = int.Parse(Console.ReadLine());

            while(Num != 0)
            {
                Posición = Posición + 1;
                if (Bandera == 0)
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
                        PosMin1 = Posición;
                    }
                    else if (Manipulador == 0)
                    {
                        Menor2 = Num;
                        Manipulador = 1;
                        PosMin2 = Posición;
                    }
                    else if(Num > Menor1 && Num <= Menor2)
                    {
                        Menor2 = Num;
                        PosMin2 = Posición;
                    }
                }
                Console.Write("Ingrese un número por favor: ");
                Num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El menor 1 es {0} y El menor 2 es {1} ", Menor1, Menor2);
            Console.WriteLine("La posicion del menor 1 es {0} ", PosMin1);
            Console.WriteLine("La posicion del menor 2 es {0} ", PosMin2);
            Console.Read();
        }
    }
}
