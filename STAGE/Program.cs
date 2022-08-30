using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.IO;

public class Program
{
    private static void Main(string[] args)
    {
        CopyFile();
        WriteCopy();
    }
    //GUI to initialize CopyFile() and WriteCopy().


    public static void CopyFile()
    {
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

    //WriteCopy() now creates an xls file. only thing needed to be changed is what is being written
    public static void WriteCopy()
    {


        Excel.Application App = new Excel.Application();
        if (App != null)
        {
            Excel.Workbook Workbook = App.Workbooks.Add();
            Excel.Worksheet Worksheet = (Excel.Worksheet)Workbook.Sheets.Add();

            string[] filePath = Directory.GetFiles(@"C:\Users\mlbud\OneDrive\Documenten\STAGEOPDRACHT\MAP2");
            var fileNames = Path.GetFileNameWithoutExtension(@"C:\Users\mlbud\OneDrive\Documenten\STAGEOPDRACHT\MAP2");
            var i = 1;

            foreach (var fileName in filePath)
                {
                    Worksheet.Cells[i++, 2] = fileName;
                    i++;
                }

                App.ActiveWorkbook.SaveAs2(@"C:\Users\mlbud\OneDrive\Documenten\STAGEOPDRACHT\pollos.xls");

                Workbook.Close();
                App.Quit();
            }
        }
    }
