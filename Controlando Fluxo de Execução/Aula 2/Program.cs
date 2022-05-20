using System;
using static System.Console;

namespace Aula_2
{
    class Program
    {

        static void Demo1()
        {
            int idade;

            Write("Digite a sua idade: ");
            idade = int.Parse(ReadLine());

            if (idade >= 18)
                WriteLine("Você é maior de idade!");
            else
                WriteLine("Você é MENOR de idade!");
        }

        static void Demo2()
        {
            int mes;

            Write("Digite um número de mês: ");
            mes = int.Parse(ReadLine());

            if (mes == 1)
                WriteLine("Janeiro");

            else if (mes == 2)
                WriteLine("Fevereiro");

            else
                WriteLine("Outro mês!");
        }
        static void Main()
        {

            int mes;

            Write("Digite um número de mês: ");
            mes = int.Parse(ReadLine());

            switch (mes)
            {
                case 1:
                    WriteLine("Janeiro");
                    break;

                case 2:
                    WriteLine("Fevereiro");
                    break;
                default:
                    WriteLine("Outro mês");
                    break;
            }


        }
    }
}
