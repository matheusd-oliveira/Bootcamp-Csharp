using System;
using System.Collections.Generic;
using System.Linq;

namespace Colecoes
{
    class List
    {
        static void Main(string[] args)
        {

            // Utilizando o LINQ 

            int[] arrayNumeros = new int[5] { 1, 4, 8, 15, 19 };

            // Utilizando o LINQ COM A SINTAXE

            var numerosParesQuery =
                from num in arrayNumeros
                where num % 2 == 0
                orderby num
                select num;

            // Outra forma de FAZER COM O LINQ
            var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            System.Console.WriteLine($"Números pares query: {string.Join(", ", numerosParesQuery)}");
            System.Console.WriteLine($"Números pares método: {string.Join(", ", numerosParesMetodo)}");
            // Stack<string> pilhaLivros = new Stack<string>();
            // Dictionary<string, string> ddds = new Dictionary<string, string>();

            // ddds.Add("SSA", "77");
            // ddds.Add("FSA", "75");
            // ddds.Add("outro estado", "81");


            // foreach (KeyValuePair<string,string> item in ddds)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }


            // string valorProcurado = "FSA";

            // if(ddds.TryGetValue(valorProcurado, out string dddEncontrado))
            //     System.Console.WriteLine(dddEncontrado);
            // else
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no Dicionário");

            // System.Console.WriteLine("Valor Original: ");
            // System.Console.WriteLine(ddds[valorProcurado]);

            // ddds[valorProcurado] = "75 - TESTE ATUALIZAÇÃO";
            // System.Console.WriteLine("Valor Atualizado: ");
            // System.Console.WriteLine(ddds[valorProcurado]);

            // System.Console.WriteLine("Removendo o valor: ");
            // ddds.Remove("SSA");


            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Código Limpo");

            // System.Console.WriteLine($"Livros para a Leitura: {pilhaLivros.Count}");
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }
            // System.Console.WriteLine($"Livros para a Leitura: {pilhaLivros.Count}");
            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Leo");
            // fila.Enqueue("Dudu");
            // fila.Enqueue("André");



            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // while (fila.Count > 0){
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // OperacoesLista opLista = new OperacoesLista();

            // List<string> estados = new List<string>();
            // string[] estadosArray = new string[2]{"SC", "MT"}; 

            // estados.Add("BA");
            // estados.Add("SP");
            // estados.Add("MG");

            // System.Console.WriteLine($"A quantidade de elementos na lista: {estados.Count}");



            // // Adicionando outra coleção dentro da lista
            // // estados.AddRange(estadosArray);

            // // Add no Indice
            // estados.Insert(1, "RJ");
            // opLista.ImprimirListaString(estados);



            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");
            // opLista.ImprimirListaString(estados);


        }
    }
}
