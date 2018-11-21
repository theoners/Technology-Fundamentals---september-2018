using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            int extensionIndex = filePath.LastIndexOf('.');
            string extension = filePath.Substring(extensionIndex+1);
            filePath = filePath.Remove(extensionIndex);
            int fileNameIndex = filePath.LastIndexOf('\\');
            string fileName = filePath.Substring(fileNameIndex+1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
