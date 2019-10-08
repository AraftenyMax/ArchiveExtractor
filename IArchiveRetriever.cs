using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IArchiveRetriever
    {
        string RequiredExtension { get; }
        string ExtractedPath { get; }
        IEnumerable<string> RetrieveArchive(string sourcePath, string destinationPath, string resolveRule);
        void ExtractArchive(string sourcePath, string destinationPath);
        void DeleteArchive();
    }
}
