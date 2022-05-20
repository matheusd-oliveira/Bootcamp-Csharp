using System;
using static System.Console;

namespace Aula_2
{
    class Program
    {
        static void Main()
        {
            int idade;

            Write("Digite a sua idade: ");
            idade = int.Parse(ReadLine());

            if (idade >= 18)
                WriteLine("Você é maior de idade!");
            else
                WriteLine("Você é MENOR de idade!");
        }
    }
}
