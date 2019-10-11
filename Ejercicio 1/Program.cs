using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cant;
            //int num;
            //int mayor = 0;
            //int menor = 0;
            //Console.Write("digite la cant de num a comparar");
            //cant = int.Parse(Console.ReadLine());
            //for (int i = 0; i < cant; i++)
            //{
            //    Console.WriteLine("escriba un numero");
            //    num = int.Parse(Console.ReadLine());
            //    if (i == 0)
            //    {
            //        mayor = num;
            //        menor = num;
            //    }
            //    else if (i != 0)
            //    {
            //        if (num < menor)
            //        {
            //            menor = num;
            //        }
            //        if (num > mayor)
            //        {
            //            mayor = num;
            //        }
            //    }
            //}
            //Console.WriteLine("el numero mayor es " + mayor);
            //Console.WriteLine("el numero mayor es " + menor);
            //Console.ReadKey();
            #region ahora con arrau
            Random rnd = new Random();
            int[] elarray = new int[10];
            for (int i = 0; i < elarray.Length; i++)
            {
                elarray[i] = rnd.Next(1, 101);
            }
            Console.Write("el arreglo dado es: ");
            foreach (var number in elarray)
            {
                Console.Write(elarray + "");
            }
            Console.WriteLine();
            getmaxandmin(elarray);
            Console.ReadLine();

             void getmaxandmin(int[] array)
            {
                int max = array[0];
                int min = array[0];
                foreach (var number in array)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                }
                Console.WriteLine("el valor maximo es: " + max);
                Console.Write("el menor es " + min);
            }
            #endregion
        }

    }
}
