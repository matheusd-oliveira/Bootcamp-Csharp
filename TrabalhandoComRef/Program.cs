using static System.Console;

class Ref
{

    static void Adicionar20(ref int a)
    {
        a += 20;
    }

    static void AlterarNome(string[] nomes, string nomeAtual, string nomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeAtual)
            {
                nomes[i] = nomeNovo;
            }
        }
    }
    static void Demo1()
    {
        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor de a é {a}!");
    }


    static void Main()
    {
        var nomes = new string[] { "Matheus", "Davi", "Narlynho", "Biel", "Felipe" };

        WriteLine($@"A lista de nomes é:
            {string.Join(", \n", nomes)}
        ");

        WriteLine("Digite o nome a ser substituido");
        var nomeAtual = ReadLine();
        WriteLine("Digite o nome novo");
        var nomeNovo = ReadLine();

        AlterarNome(nomes, nomeAtual, nomeNovo);
        WriteLine($@"A lista de nomes alterada é:
            {string.Join(", \n", nomes)}
        ");
    }   
}