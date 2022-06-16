using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        CopyFile();   
    }

    public static void CopyFile()
    {
        //Finds directory with the images
        string filep = @"C:\Gebruikers\mlbud\OneDrive\Documenten\STAGEOPDRACHT\MAP1";

        string[] filePath = Directory.GetFiles(@"C:\Users\mlbud\OneDrive\Documenten\STAGEOPDRACHT\MAP1\");
        Console.WriteLine("Found directory");

        //Foreach loop goes through every file in the directory
        foreach (var fileName in filePath)
        {            
            var bestandNaam = Path.GetFileName(fileName);
            string file = fileName.ToString();
            string fileDest = @"C:\Users\mlbud\OneDrive\Documenten\STAGEOPDRACHT\MAP2\" + bestandNaam;

            string copyFolderFrom = fileName;
            {
                File.Copy(copyFolderFrom, fileDest, true);
                Console.WriteLine("Copied file to folder");
            }
        }
    }
}