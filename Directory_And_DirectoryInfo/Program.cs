CriarDiretoriosGlobo();
//CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(
    Environment.CurrentDirectory,
    "globo", "América do Sul",
    "Brasil", "brasil.txt");

MoverArquivo(origem, destino);
CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{   
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe.");
        return;
    }

    if (!File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo de destino não existe.");
        return;
    }
    
    File.Copy(pathOrigem, pathDestino);
}


static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe.");
        return;
    }

    if (!File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo de destino não existe.");
        return;
    }


    File.Move(pathOrigem, pathDestino);


}


static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213MM");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em: 20/04/2018");
    }

}


static void CriarDiretoriosGlobo()
{

    var path = Path.Combine(Environment.CurrentDirectory, "globo");

    if (!Directory.Exists(path))
    {
        var diretorioGlobo = Directory.CreateDirectory(path);

        var diretorioAmNorte = diretorioGlobo.CreateSubdirectory("América do Norte");
        var diretorioAmCentral = diretorioGlobo.CreateSubdirectory("América Central");
        var diretorioAmSul = diretorioGlobo.CreateSubdirectory("América do Sul");

        diretorioAmNorte.CreateSubdirectory("USA");
        diretorioAmNorte.CreateSubdirectory("México");
        diretorioAmNorte.CreateSubdirectory("Canadá");

        diretorioAmCentral.CreateSubdirectory("Costa Rica");
        diretorioAmCentral.CreateSubdirectory("Panamá");


        diretorioAmSul.CreateSubdirectory("Brasil");
        diretorioAmSul.CreateSubdirectory("Argentina");
        diretorioAmSul.CreateSubdirectory("Paraguai");
    }

}




