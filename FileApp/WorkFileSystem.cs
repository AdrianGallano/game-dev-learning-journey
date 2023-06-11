using System.IO;
using System.Diagnostics;
using FileApp.Exceptions;
using Newtonsoft.Json;


namespace FileApp
{
  public static class WorkFileSystem
  {
    public static void ListSubdirectories(string? directory)
    {
      if (directory == null) throw new NullReferenceException("cannot have null directory");
      if (directory == "") throw new EmptyStringException("Cannot have empty directory");

      IEnumerable<string> listOfSubdirectories = Directory.EnumerateDirectories(directory);

      Debug.WriteLine(listOfSubdirectories);

      Console.WriteLine("\nSubDirectories\n");
      foreach (string subdirectory in listOfSubdirectories)
      {
        Console.WriteLine(subdirectory);
      }
    }

    public static void ListAllFiles(string? directory)
    {
      if (directory == null) throw new NullReferenceException("cannot have null directory");
      if (directory == "") throw new EmptyStringException("Cannot have empty directory");

      IEnumerable<string> listOfAllFiles = Directory.EnumerateFiles(directory, "*", SearchOption.AllDirectories);

      Console.WriteLine("\nAll Files\n");
      foreach (string file in listOfAllFiles)
      {
        Console.WriteLine(file);
      }
    }

    public static void FindFile(string? directory, string? fileName)
    {
      if (directory == null) throw new NullReferenceException("cannot have null directory");
      if (directory == "") throw new EmptyStringException("Cannot have empty directory");
      if (fileName == null) throw new NullReferenceException("cannot have null file name");
      if (fileName == "") throw new EmptyStringException("Cannot have empty file name");

      IEnumerable<string> listOfAllFiles = Directory.EnumerateFiles(directory, "*", SearchOption.AllDirectories);

      Console.WriteLine("\nFiles Found\n");
      foreach (string file in listOfAllFiles)
      {
        if (file.EndsWith(fileName))
        {
          Console.WriteLine(file);
        }
      }
    }

    public static bool CheckExist(string path)
    {
      return Directory.Exists(path);
    }

    public static void CreateDirectory(string directory, string newDirectory)
    {
      if (directory == null) return;

      Directory.CreateDirectory(Path.Combine(FilePaths.GetCurrentDirectory(), directory, newDirectory));
    }

    public static void CreateFiles(string directory, string newFile)
    {
      if (directory == null) return;

      File.WriteAllText(FilePaths.JoinPaths(FilePaths.GetCurrentDirectory(), directory, newFile), "Hello World!");
    }

    public static void ReadFile(string directory, string file){

      string readFile = File.ReadAllText(FilePaths.JoinPaths(FilePaths.GetCurrentDirectory(), directory, file));
      Debug.WriteLine(readFile);
    }
  }
}