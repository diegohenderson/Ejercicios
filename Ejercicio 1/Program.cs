using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant;
            int num;
            int mayor = 0;
            int menor = 0;
            Console.Write("digite la cant de num a comparar");
            cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("escriba un numero");
                num = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    mayor = num;
                    menor = num;
                }
                else if (i != 0)
                {
                    if (num < menor)
                    {
                        menor = num;
                    }
                    if (num>mayor)
                    {
                        mayor = num;
                    }
                }
            }
            Console.WriteLine("el numero mayor es " + mayor);
            Console.WriteLine("el numero mayor es " + menor);
            Console.ReadKey();
        }
    }
}
