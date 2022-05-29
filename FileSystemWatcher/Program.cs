var path = @"C:\Users\mathe\Desktop\DIO\Directory_And_DirectoryInfo\globo";

using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine("Monitorando eventos na pasta globo...");
await Task.Delay(2000);

Console.WriteLine("Pressione [ENTER] para finalizar...");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
    throw new NotImplementedException();
}


void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} renomeado para o arquivo {e.Name}");
    throw new NotImplementedException();
}



void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi deletado o arquivo {e.Name}");
    throw new NotImplementedException();
}