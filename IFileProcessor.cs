using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IFileProcessor
    {
        string ResolveRule
        {
            get;
        }
        void ProcessFile(string PathToFile);
    }
}
