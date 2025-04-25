using CountYourWords;
using System.Collections;
using System.Text.RegularExpressions;

public class Program 
{

    static void Main(string[] args)
    {
        var countingProcessor = new CountingProcessor();
        var parsingProcessor = new ParsingProcessor();
        var sortingProcessor = new SortingProcessor();



        string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string FileName = "Fox.txt";
        string FilePath = Path.Combine(FolderPath, FileName); string Text;


        string FileData;

        if (!File.Exists(FilePath))
        {
            Console.WriteLine("File not Found: " + FilePath);
            return;
        }

        FileData = parsingProcessor.ParseTextFile(FilePath);       
        string SortedData = sortingProcessor.SortingTheText(FileData);
        Text = countingProcessor.CountingTheWords(SortedData);
        Console.WriteLine(Text);
    
    }










    




}