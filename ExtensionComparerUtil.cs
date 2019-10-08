using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class ExtensionComparerUtil
    {
        public static bool ExtensionValidityCheck(string extension, string requireExtension)
        {
            return extension == requireExtension;
        }

        public static bool ExtensionValidityCheck(string extension, List<string> extensions)
        {
            return extensions.Contains(extension);
        }
    }
}
