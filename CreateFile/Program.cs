using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateNewFile();
            Console.WriteLine("Enter the file name: ");
            string userinput = Console.ReadLine();
            //CreateUserFile(userinput);
            CreateExtension(userinput);
        }
        public static void CreateNewFile()
        {
            string rootPath = @"C:\Users\martv\Desktop\samples\Player1";
            string fileName = "ball.txt";
            File.Create(Path.Combine(rootPath, fileName));
        }
        public static void CreateUserFile(string fileName)
        {
            string rootPath = @"C:\Users\martv\Desktop\samples\Player2";           
            File.Create(Path.Combine(rootPath, fileName));
        }
        public static void CreateExtension(string fileName)
        {
            string rootPath = @"C:\Users\martv\Desktop\samples\Player2";
            string fullFileName = $"{fileName}.txt";
            File.Create(Path.Combine(rootPath, fullFileName));
        }
    }
}
