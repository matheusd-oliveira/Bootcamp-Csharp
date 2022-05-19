using static System.Console;

class Ref
{

    static void Adicionar20(ref int a)
    {
        a += 20;
    }

    static void Demo1()
    {
        int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor de a é {a}!");
    }
    static void Main()
    {


    }
}