using System;
using System.Collections.Generic;

namespace Colecoes
{
    class List
    {
        static void Main(string[] args){
            
            OperacoesLista opLista = new OperacoesLista();

            List<string> estados = new List<string>();
            string[] estadosArray = new string[2]{"SC", "MT"}; 

            estados.Add("BA");
            estados.Add("SP");
            estados.Add("MG");

            System.Console.WriteLine($"A quantidade de elementos na lista: {estados.Count}");
            
            opLista.ImprimirListaString(estados);
            
            // Adicionando outra coleção dentro da
            estados.AddRange(estadosArray);
            opLista.ImprimirListaString(estados);
            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");
            // opLista.ImprimirListaString(estados);


        }
    }
}
    