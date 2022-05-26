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


        

        }
    }
}
