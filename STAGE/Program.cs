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

        string[] filePath = Directory.GetFiles(@"C:\Users\mlbud\OneDrive\Documenten\STAGEOPDRACHT\MAP1");
        //Foreach loop goes through every file in the directory
        foreach (var fileName in filePath)
        {
            Path.GetFileNameWithoutExtension(fileName);
            var bestandNaam = Path.GetFileName(fileName);

            string file = fileName.ToString();
            //fileDest means file destination
            string fileDest = @"C:\Users\mlbud\OneDrive\Documenten\STAGEOPDRACHT\MAP2" + bestandNaam;

            string copyFolderFrom = filePath + file;
            string copyFolderTo = fileDest + file;
            {
                File.Copy(copyFolderFrom, copyFolderTo, true);
            }
        }
    }
}