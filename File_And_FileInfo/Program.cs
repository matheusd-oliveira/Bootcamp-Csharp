using static System.Console;

// Criando arquivos.
Write("Digite o nome do arquivo: ");
var nome = ReadLine();

// Tratando erros com GetInvalidFileNameChars
nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");


CriarArquivo(path);
WriteLine();

WriteLine("Digite enter para finalizar...");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}
static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);

        // Escrevendo em memória no arquivo.
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 2 do arquivo");
        sw.WriteLine("Esta é a linha 3 do arquivo");

        // Dando o flush para descarregar as linhas escritas da memória para o arquivo.
        sw.Flush();
        WriteLine("Arquivo criado com sucesso!");
    }
    catch
    {
        WriteLine("Nome do Arquivo está incorreto!");
    }

}
