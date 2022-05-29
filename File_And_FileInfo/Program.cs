using static System.Console;

// Criando arquivos.
Write("Digite o nome do arquivo: ");
var nome = ReadLine();
var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");


CriarArquivo(path);
WriteLine();
WriteLine("Arquivo criado com sucesso!");



static void CriarArquivo(string path)
{
    using var sw = File.CreateText(path);

    // Escrevendo em memória no arquivo.
    sw.WriteLine("Esta é a linha 1 do arquivo");
    sw.WriteLine("Esta é a linha 2 do arquivo");
    sw.WriteLine("Esta é a linha 3 do arquivo");

    // Dando o flush para descarregar as linhas escritas da memória para o arquivo.
    sw.Flush();
}
