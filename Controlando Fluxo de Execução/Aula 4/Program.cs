using System;
using static System.Console;

namespace Aula_4
{
    class Program
    {
        static void Main()
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
                    break;
                }
                else
                {
                    WriteLine("O valor informado é:" + valor);
                    WriteLine();
                    continue;

                }
            }
        }
    }
}
