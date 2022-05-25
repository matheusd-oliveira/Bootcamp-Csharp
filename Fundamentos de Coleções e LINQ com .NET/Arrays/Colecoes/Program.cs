﻿using System;
using static System.Console;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] { 4, 2, 8, 10, 6 };

            WriteLine("Array Original:");
            op.ImprimirArray(array);

            op.OrdenarBubbleSort(ref array);

            WriteLine("Array Ordenado:");
            op.ImprimirArray(array);
            
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
