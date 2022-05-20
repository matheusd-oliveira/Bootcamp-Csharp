using static System.Console;

// Comparando referências
// Logo, as referencias são diferentes. Para serem iguais, é necessário comparar valores.

Numero a = new Numero(2);
Numero b = new Numero(2);

if (a == b)
    WriteLine("a e b são iguais");
else
    WriteLine("a e b são diferentes");

// Comparando os valores
if (a.N == b.N)
    WriteLine("a e b são iguais");
else
    WriteLine("a e b são diferentes");

class Numero
{
    public int N { get; set; }

    public Numero(int n)
    {
        N = n;
    }
}


