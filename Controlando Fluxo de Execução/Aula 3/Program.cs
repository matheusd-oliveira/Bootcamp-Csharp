using System;
using static System.Console;
namespace Aula_3
{
    class Program
    {

        static void Demo1()
        {
            bool condicao = true;
            int valor;

            while (condicao)
            {
                WriteLine("Digite um valor. 0 para sair.");
                valor = int.Parse(ReadLine());


                if (valor == 0)
                {
                    WriteLine("Você saiu da aplicação");
                    condicao = false;
                }
                else
                    WriteLine("O valor informado é:" + valor);
                WriteLine();
            }
        }

        static void Demo2()
        {
            int valor;
            WriteLine("Digite um valor");
            valor = int.Parse(ReadLine());

            for (int i = valor; i <= 10; i++)
            {
                WriteLine(i);
            }
        }
        static void Main()
        {
            int[] lista = { 1, 2, 3, 4, 5, };

            foreach(int numero in lista)
                WriteLine(numero);
        }
    }
}

