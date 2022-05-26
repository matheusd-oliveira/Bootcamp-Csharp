using System;
using System.Collections.Generic;
namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> estados = new List<string>();
           estados.Add("BA");
           estados.Add("MG");
           estados.Add("SP");
           estados.Add("RJ");
		   System.Console.WriteLine($"Quantidade de elementos da lista: {estados.Count}");
           
           foreach (var item in estados)
           {
               System.Console.WriteLine(item);
           }

           for (int i = 0; i < estados.Count; i++)
           {
               System.Console.WriteLine($"Índice {i}, Valor: {estados[i]}");
           }

        }
    }
}
