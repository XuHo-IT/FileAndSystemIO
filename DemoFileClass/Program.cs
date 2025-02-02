﻿
namespace DemoFileClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"file.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using StreamWriter sw = File.CreateText(path);
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }

            // Open the file to read from.
            using StreamReader sr = File.OpenText(path);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
