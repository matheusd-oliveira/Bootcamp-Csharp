var path = @"c:\Users\mathe\Desktop\DIO\Directory_And_DirectoryInfo\globo";

LerDiretorios(path);
Console.WriteLine("Digite ENTER para finalizar...");
Console.ReadLine();


void LerDiretorios(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

        foreach (var diretorio in diretorios)
        {
            var diretorioInfo = new DirectoryInfo(diretorio);
            Console.WriteLine($"[Nome]: {diretorioInfo.Name}");
            Console.WriteLine($"[Raiz]: {diretorioInfo.Root}");
            if (diretorioInfo.Parent != null)
                Console.WriteLine($"[Pai]: {diretorioInfo.Parent.Name}");

            Console.WriteLine("----------------------");

        }
    }
    else 
        Console.WriteLine($"{path} não existe");

}