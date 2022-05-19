using static System.Console;

class Ref
{

    static void Adicionar20(ref int a)
    {
        a += 20;
    }
    static void Main()
    {

        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor de a é {a}!");
    }
}