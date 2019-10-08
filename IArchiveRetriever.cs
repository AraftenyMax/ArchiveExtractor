using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IArchiveRetriever
    {
        string ResolveRule { get; }
        string ExtractedPath { get; }
        IEnumerable<string> RetrieveArchive(string path);
        void ExtractArchive(string path);
        void DeleteArchive(string path);
    }
}
