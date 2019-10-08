using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArchiveProcessor
    {
        IArchiveRetriever ArchiveRetriever;
        IFileProcessor FileProcessor;
        public ArchiveProcessor(IArchiveRetriever archiveRetriever, IFileProcessor fileProcessor)
        {
            ArchiveRetriever = archiveRetriever;
            FileProcessor = fileProcessor;
        }
        public void ProcessArchive(string PathToFolder)
        {
            var ArchiveFiles = ArchiveRetriever.RetrieveArchive(PathToFolder);
            foreach(string PathToFile in ArchiveFiles)
            {
                FileProcessor.ProcessFile(PathToFile);
            }
        }
    }
}
