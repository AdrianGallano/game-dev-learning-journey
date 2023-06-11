using System.IO;
using FileApp.Exceptions;
using System.Diagnostics;

namespace FileApp
{
  public static class FilePaths
  {
    public static string GetCurrentDirectory()
    {
      return Directory.GetCurrentDirectory();
    }

    public static string GetRootDirectory()
    {

      return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }

    public static string? JoinPaths(string? CurrentDirectory, params string[]? Paths)
    {
      if (Paths == null) throw new EmptyPathException("Cannot have empty path.");
      if (Paths.Length == 0) throw new EmptyPathException("Cannot have empty path.");
      if (CurrentDirectory == null) throw new EmptyStringException("Cannot have empty directory.");

      string? pathHolder = CurrentDirectory;


      foreach (string path in Paths)
      {
        pathHolder = Path.Combine(pathHolder, path);
      }
      return pathHolder;
    }

    public static string? GetExtension(string? fileName)
    {
      if (fileName == null) return null;

      string extension = Path.GetExtension(fileName);

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

    public static List<string> GetAllWithExtension(string? directory, string? extension)

    {
      if (extension == null) throw new NullReferenceException("cannot have null extension");
      if (extension == "") throw new EmptyStringException("Cannot have empty extension");
      if (directory == null) throw new NullReferenceException("cannot have null directory");
      if (directory == "") throw new EmptyStringException("Cannot have empty directory");

      Debug.WriteLine(directory);
      IEnumerable<string> AllFiles = Directory.EnumerateFiles(directory, "*", SearchOption.AllDirectories);
      List<string> filesWithExtension = new List<string>();

      foreach (string file in AllFiles)
      {
        Debug.WriteLine(FilePaths.GetExtension(file) == extension);
        if (FilePaths.GetExtension(file) == extension)
        {
          filesWithExtension.Add(file);
        }
      }

      return filesWithExtension;
    }
  }
}