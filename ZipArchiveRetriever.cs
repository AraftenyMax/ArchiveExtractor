using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ConsoleApp1
{
    class ZipArchiveRetriever : IArchiveRetriever
    {
        string _ExtractedPath = "";
        string _RequiredExtension = ArchiveExtensions.Zip;

        public string RequiredExtension
        {
            get => _RequiredExtension;
        }
        public string ExtractedPath
        {
            get => _ExtractedPath;
        }

        public void DeleteArchive()
        {
            if (_ExtractedPath == String.Empty)
            {
                Console.WriteLine("Passed path is empty. There\'s nothing to delete");
                return;
            }
            if (!Directory.Exists(_ExtractedPath))
            {
                Console.WriteLine("Extracted folder magically disappeared. No need to perform cleanup.");
                return;
            }
            Directory.Delete(_ExtractedPath, true);
            _ExtractedPath = "";
        }

        public void ExtractArchive(string sourcePath, string destinationPath)
        {
            if (!File.Exists(sourcePath))
            {
                throw new FileNotFoundException($"File with path {sourcePath} couldn\'t be found.");
            }
            if (Directory.Exists(destinationPath))
            {
                throw new InvalidOperationException($"Folder with path {destinationPath} shouldn\'t exist.");
            }
            string extension = sourcePath.Substring(sourcePath.LastIndexOf("."));
            if (extension != _RequiredExtension)
            {
                throw new ArgumentException($"Incompatible extension got: {extension} while waiting for {_RequiredExtension}");
            }
            ZipFile.ExtractToDirectory(sourcePath, destinationPath);
            _ExtractedPath = destinationPath;
        }

        public IEnumerable<string> RetrieveArchive(string sourcePath, string destinationPath, string resolveRule = "*")
        {
            ExtractArchive(sourcePath, destinationPath);
            IEnumerable<string> files = Directory.EnumerateFiles(_ExtractedPath, resolveRule);
            Console.WriteLine($"Folder with path: {_ExtractedPath} successfully extracted.");
            return files;
        }
    }
}
