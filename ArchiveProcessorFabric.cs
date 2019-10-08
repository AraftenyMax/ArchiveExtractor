using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArchiveProcessorFabric
    {
        public static ArchiveProcessor Create(string resolveRule)
        {
            IArchiveRetriever archiveRetriever = new ZipArchiveRetriever();
            IFileProcessor fileProcessor = new CsvProcessor(resolveRule);
            return new ArchiveProcessor(archiveRetriever, fileProcessor);
        }
    }
}
