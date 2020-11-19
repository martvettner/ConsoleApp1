using System;
using System.IO;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveFile();
        }
        public static void MoveFile()
        {
            string sourceDirectroy = @"C:\Users\martv\Desktop\samples\Player1";
            string destinationPath = @"C:\Users\martv\Desktop\samples\Player2";
            string fileName = "ball.txt";

            File.Move(Path.Combine(sourceDirectroy, fileName), Path.Combine(destinationPath, fileName));

        }
    }
}
