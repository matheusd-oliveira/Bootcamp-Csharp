using System;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

try
{
    int divisao = Dividir(a, b);

    System.Console.WriteLine(divisao);
}
catch (DivideByZeroException Exception)
{
    System.Console.WriteLine(Exception.Message);
}

catch (System.Exception Exception)
{
    System.Console.WriteLine(Exception.Message);

}
finally
{
    System.Console.WriteLine("Finalmente a divisão foi finalizada!");
}



static int Dividir(int x, int y)
{   
    if(y == 0)
        throw new ArithmeticException();
    return (x / y);
}

