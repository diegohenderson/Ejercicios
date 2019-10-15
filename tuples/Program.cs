using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array
            //string[] listacompra = new string[4];
            //listacompra[0] = "leche";
            //listacompra[1] = "asd";
            //listacompra[2] = "13";
            //listacompra[3] = "le54che";
            //foreach (string item in listacompra)
            //{
            //    Console.Write(item + ",");
            //}
            //int[] numeros = { 1, 2, 3, 4, 5, 6 };
            //int suma = 0;
            //foreach (int item in numeros)
            //{
            //    suma = suma + item;
            //}
            //Console.WriteLine(suma);
            #endregion
            List<int> listanumeros = new List<int>();
            listanumeros.Add(15);
            listanumeros.Add(22);
            listanumeros.Add(33);
            //Console.WriteLine(listanumeros.Count);
            #region muestra y algunos metodos
            //listanumeros.Insert(0, 99);
            //listanumeros.Reverse();
            //if (listanumeros.Contains(15))
            //{
            //    Console.WriteLine("si");
            //}
            //foreach (int numero in listanumeros)
            //{
            //    Console.WriteLine(numero);
            //}
            #endregion
            #region recorrer lista
            //foreach (int item in listanumeros)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine (listanumeros.IndexOf(item));//el indice
            //}
            #endregion
            #region diccionarios
            //Dictionary<string, string> alumnos = new Dictionary<string, string>();
            //alumnos.Add("a", "paula");
            //alumnos.Add("b", "asd");
            //alumnos.Add("c", "123");
            ////Console.WriteLine(alumnos["b"]);
            //alumnos.Remove("a");
            //foreach (KeyValuePair<string,string >item in alumnos) //el tipo es keyvalue primero key y desp valeu o podes poner var...
            //{
            //    Console.WriteLine("clave " + item.Key + ":" + item.Value);
            //}
            #endregion
            List<List<string>> myList = new List<List<string>>();
            myList.Add(new List<string> { "a", "b" });
            myList.Add(new List<string> { "c", "d", "e" });
            myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
            myList.Add(new List<string> { "a", "b" });
            myList.Insert(0,new List<string> { "asd" });
            
            // To iterate over it.
            foreach (List<string> subList in myList)
            {
                foreach (string item in subList)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }

    }
}
