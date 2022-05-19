using System;


namespace DIO
{
    class Program
    {
        static int Adicionar20(int x)
        {
            x += 20;
            return x;
        }
        static void TrocarNome(Pessoa p1, string nomeNovo)
        {

            p1.Nome = nomeNovo;
        }

        static StructPessoa TrocarNomeStruct(StructPessoa p1, string nomeNovoStruct)
        {
            p1.Nome = nomeNovoStruct;
            return p1;
        }

        static string TrocarNomeString(string nome, string nomeNovoString)
        {
            nome = nomeNovoString;
            return nome;
        }

        static void MudarParaImpar(int[] pares)
        {
            for (int contador = 0; contador < pares.Length; contador++)
            {
                pares[contador] += 1;

            }
        }
        static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);

            Console.WriteLine($"o valor da variável a é {a}");
        }

        static void Demo2()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Matheus";
            p1.Idade = 21;
            p1.Documento = "123";

            Pessoa p2 = p1.Clone();


            TrocarNome(p1, "Davi");

            Console.WriteLine($@"
            O nome de p1 é: {p1.Nome}
            O nome de p2 é: {p2.Nome}
            ");
        }

        static void Demo3()
        {
            StructPessoa p1 = new StructPessoa()
            {

                Documento = "1234",
                Idade = 30,
                Nome = "Narlyson"
            };
            var p2 = p1;

            p1 = TrocarNomeStruct(p1, "João");

            Console.WriteLine($@"
            O nome de p1 é: {p1.Nome}
            O nome de p2 é: {p2.Nome}
            ");
        }

        static void Demo4()
        {
            string nome = "Matheus";

            nome = TrocarNomeString(nome, "Thegas");

            Console.WriteLine($"O novo nome é {nome}");
        }
        public static void Main()
        {

            int[] pares = new int[] { 0, 2, 4, 6, 8 };

            MudarParaImpar(pares);

            Console.WriteLine($"Os ímpares {string.Join(",", pares)}");
        }
    }
}
