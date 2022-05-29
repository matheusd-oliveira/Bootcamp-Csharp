using static System.Console;

var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "usuarios-exportacao.csv");

using var sr = new StreamReader(path);
var cabecalho = sr.ReadLine()?.Split(',');

while (true)
{
    var registro = sr.ReadLine()?.Split(',');
    if (registro == null)
        break;
    
    for (int i = 0; i < registro.Length; i++)
    {
        WriteLine($"{cabecalho?[i]}: {registro[i]}");
    }

    WriteLine("---------------");
    WriteLine("Pressione [ENTER] para finalizar...");
    ReadLine();
}