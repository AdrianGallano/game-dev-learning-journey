
using FileApp;
using Newtonsoft.Json;

Console.Write("Enter directory name: ");
string? directoryName = Console.ReadLine();

Console.Write("Enter file name to find: ");
string? fileName = Console.ReadLine();

Console.Write("Enter extension to find: ");
string? extension = Console.ReadLine();

WorkFileSystem.ListSubdirectories(directoryName);
WorkFileSystem.ListAllFiles(directoryName);
WorkFileSystem.FindFile(directoryName, fileName);
FilePaths.GetCurrentDirectory();
FilePaths.GetRootDirectory();
FilePaths.GetExtension(fileName);

if (directoryName != null)
{
  string? filePath = FilePaths.JoinPaths(FilePaths.GetCurrentDirectory(), directoryName);
  FilePaths.ShowFileInfo(filePath);
  FilePaths.GetAllWithExtension(filePath, extension);
  WorkFileSystem.CreateDirectory(directoryName, "203");
  WorkFileSystem.CreateFiles(directoryName, "something.txt");
  WorkFileSystem.ReadFile(directoryName, fileName);
}



var salesJson = File.ReadAllText(FilePaths.JoinPaths(FilePaths.GetCurrentDirectory(), "stores", "sales.json"));
var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
Console.WriteLine(salesData.Total);


public class SalesTotal
{
  public double Total { get; set; }
}


