// Criando arquivos.

var path = Path.Combine(Environment.CurrentDirectory, "teste.txt");

using var sw = File.CreateText(path);

// Escrevendo em memória no arquivo.
sw.WriteLine("Esta é a linha 1 do arquivo");
sw.WriteLine("Esta é a linha 2 do arquivo");
sw.WriteLine("Esta é a linha 3 do arquivo");

// Dando o flush para descarregar as linhas escritas da memória para o arquivo.
sw.Flush();