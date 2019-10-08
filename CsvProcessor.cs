using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class CsvProcessor : IFileProcessor
    {
        string _ResolveRule;
        public string ResolveRule
        {
            get => _ResolveRule;
        }

        public CsvProcessor(string resolveRule)
        {
            _ResolveRule = resolveRule;
        }

        public void ProcessFile(string PathToFile)
        {
            string data = File.ReadAllText(PathToFile);
            Console.WriteLine($"File with path: {PathToFile} has ${data.Length} characters.");
        }
    }
}
