using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = " asd ->32 ->ads-> gfd-> hola";
            string[] arreglo = cadena.Split("->".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);//si quiero leer un espacio,dejarlo vacio, sino agregarle simbolo correspondiente
            //si son 2 simbolos diferentes, usamos tochararray , y podemos remover los espacios
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);

            }
            Console.ReadKey();
        }
    }
}
