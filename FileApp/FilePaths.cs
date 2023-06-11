using System.IO;

namespace FileApp
{
  public static class FilePaths
  {
    public static void GetCurrentDirectory()
    {
      Console.WriteLine("\nCurrent Directory\n");
      Console.WriteLine(Directory.GetCurrentDirectory());
    }

    public static void GetRootDirectory()
    {
      Console.WriteLine("\nRoot Directory\n");
      string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      Console.WriteLine(path);
    }

    public static string? JoinPaths(params string[] paths)
    {
      if (paths.Length == 0) return null;
      string? pathHolder = string.Empty;


      Console.WriteLine("\nJoint Path\n");
      foreach (string path in paths)
      {
        pathHolder = Path.Combine(pathHolder, path);
      }
      Console.WriteLine(pathHolder);
      return pathHolder;
    }

    public static string? GetExtension(string? fileName)
    {
      if (fileName == null) return null;

      string extension = Path.GetExtension(fileName);
      Console.WriteLine("\nExtension\n");
      Console.WriteLine($"The extension of {fileName} is {extension}");

      return extension;
    }

    public static void ShowFileInfo(string? path)
    {
      if (path == null) return;

      FileInfo fileInfo = new FileInfo(path);

      Console.WriteLine("\nFile Information\n");
      Console.WriteLine($"File Name: {fileInfo.Name}{Environment.NewLine} File Extension: {fileInfo.Extension}{Environment.NewLine}");
      Console.WriteLine($"File Creation: {fileInfo.CreationTime}{Environment.NewLine} File Directory: {fileInfo.Directory}{Environment.NewLine}");
    }
  }
}