using System;
using System.IO;

namespace RainbowSchools
{
    namespace RainbowSchools
    {
        internal class Program
        {
            public static void FileFun()
            {
                string path = @"C:\Users\HP\source\repos\RainbowSchools\RainbowSchools\StudentData.txt";

                if (File.Exists(path))
                {
                    StreamReader sr = File.OpenText(path);
                    string tillEnd = sr.ReadToEnd();
                    Console.WriteLine(tillEnd);
                    sr.Close();
                }
                else
                {
                    Console.WriteLine("File Not Found\nPlease Create StudentData.txt file\n");
                }
            }
            static void Main(string[] args)
            {
                FileFun();
            }
        }
    }
}
