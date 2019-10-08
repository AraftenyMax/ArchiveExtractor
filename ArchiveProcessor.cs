using System;
using System.Collections.Generic;
using System.IO;
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
        public void ProcessArchive(string PathToArchive, string DestinationPath)
        {
            try
            {
                var ArchiveFiles = ArchiveRetriever.RetrieveArchive(PathToArchive, DestinationPath, FileProcessor.ResolveRule);
                foreach (string PathToFile in ArchiveFiles)
                {
                    FileProcessor.ProcessFile(PathToFile);
                }
            }catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ArchiveRetriever.DeleteArchive();
            }
        }
    }
}
