using System;
using static System.Console;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] { 4, 2, 8, 10, 6 };
            int[] arrayCopia = new int[10];
            string[] arrayString = op.ConverterArrayParaString(array);
           // int valorProcurado = 6;

            WriteLine($"Capacidade atual do array: {array.Length}");
            op.RedimensionarArray(ref array, array.Length * 2);

            WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");
            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            //     WriteLine($"O indice do elemento {valorProcurado} é {indice}");
            // else   
            //     WriteLine("Valor não existente no array.");

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if (valorAchado > 0)
            //     WriteLine("Encontrei");
            // else
            //     WriteLine("Não encontrei");

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(todosMaiorQue)
            //     WriteLine($"Todos os valores são maior que {valorProcurado}");
            // else
            //     WriteLine($"Existem valores que não são maiores que {valorProcurado}");
            // int valorProcurado = 2;
            // bool existe = op.Existe(array, valorProcurado);
            // if(existe)
            //     WriteLine($"Encontrei o valor: {valorProcurado}");
            // else
            //     WriteLine($"Não encontrei o valor {valorProcurado}");

            // WriteLine("Array Original:");
            // op.ImprimirArray(array);

            // op.OrdenarBubbleSort(ref array);

            // WriteLine("Array Ordenado:");
            // op.ImprimirArray(array);

            // WriteLine("Array Ordenado pela classe Array:");
            // op.Ordenar(ref array);
            // op.ImprimirArray(array);

            // WriteLine("Array antes da Cópia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // WriteLine("Array após a cópia: ");
            // op.ImprimirArray(arrayCopia);
            
            // int[,] matriz = new int[4, 2]{
            //     { 8, 8},
            //     {10, 20},
            //     {5, 100},
            //     {90, 200}
            // };

            // for (int l = 0; l < matriz.GetLength(0); l++)
            // {
            //     for (int c = 0; c < matriz.GetLength(1); c++)
            //     {
            //         WriteLine(matriz[l, c]);
            //     }
            // }


            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");


            // WriteLine("Percorrendo array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     WriteLine(arrayInteiros[i]);
            // }

            // WriteLine("Percorrendo array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     WriteLine(item);
            // }
        }
    }
}
