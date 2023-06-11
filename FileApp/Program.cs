
using FileApp;

Console.Write("Enter directory name: ");
string? directoryName = Console.ReadLine();

Console.Write("Enter file name to find: ");
string? fileName = Console.ReadLine();

WorkFileSystem.ListSubdirectories(directoryName);
WorkFileSystem.ListAllFiles(directoryName);
WorkFileSystem.FindFile(directoryName, fileName);
FilePaths.GetCurrentDirectory();
FilePaths.GetRootDirectory();
FilePaths.GetExtension(fileName);
string? filePath = FilePaths.JoinPaths("stores", "201", "sales.json");
FilePaths.ShowFileInfo(filePath);
