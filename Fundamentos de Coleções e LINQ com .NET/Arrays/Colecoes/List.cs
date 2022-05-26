using System;
using System.Collections.Generic;

namespace Colecoes
{
    class List
    {
        static void Main(string[] args){
            
            OperacoesLista opLista = new OperacoesLista();

            List<string> estados = new List<string>();
            estados.Add("BA");
            estados.Add("SP");
            estados.Add("MG");

            System.Console.WriteLine($"A quantidade de elementos na lista: {estados.Count}");
            
            opLista.ImprimirListaString(estados);

            estados.Remove();

        }
    }
}
    