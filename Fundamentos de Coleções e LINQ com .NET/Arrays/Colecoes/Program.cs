using System;
using static System.Console;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;

            WriteLine("Percorrendo array pelo for");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                WriteLine(arrayInteiros[i]);
            }

            WriteLine("Percorrendo array pelo foreach");
            foreach (int item in arrayInteiros)
            {
                WriteLine(item);
            }
        }
    }
}
