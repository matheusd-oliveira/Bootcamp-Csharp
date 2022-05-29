var path = @"C:\Users\mathe\Desktop\DIO\Directory_And_DirectoryInfo\globo";

using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

void OnCreated(object sender, FileSystemEventArgs e)
{
    throw new NotImplementedException();
}


void OnRenamed(object sender, RenamedEventArgs e)
{
    throw new NotImplementedException();
}



void OnDeleted(object sender, FileSystemEventArgs e)
{
    throw new NotImplementedException();
}