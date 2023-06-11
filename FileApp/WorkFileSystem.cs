using System.IO;
using System.Diagnostics;

namespace FileApp
{
  public static class WorkFileSystem
  {
    public static void ListSubdirectories(string? directory)
    {
      if (directory == null) throw new NullReferenceException("cannot have null directory");

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
      if (fileName == null) throw new NullReferenceException("cannot have null file name");

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
  }
}