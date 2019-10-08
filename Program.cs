using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    // WorkItem implicitly inherits from the Object class.
    class Program
    {
        static void Main()
        {
            string prompt = "y";
            while (prompt != "n")
            {
                try
                {
                    Console.WriteLine("Enter please source folder path: ");
                    string sourcePath = Console.ReadLine();
                    //string sourcePath = @"D:\Book1.zip";
                    //string destPath = @"D:\Book4";
                    Console.WriteLine("Enter please destionation folder path: ");
                    string destPath = Console.ReadLine();
                    ArchiveProcessor processor = ArchiveProcessorFabric.Create("*.csv");
                    processor.ProcessArchive(sourcePath, destPath);
                }
                finally
                {
                    Console.WriteLine("Do want to continue? (y/n)");
                    prompt = Console.ReadLine();
                }
            }
        }
    }
}
