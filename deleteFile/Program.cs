using System;
using System.IO;

namespace deleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDelete();
        }
        public static void FileDelete()
        {
            string rootPath = @"C:\Users\martv\Desktop\samples\Player2";
            string fileName = "ball.txt";
            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
