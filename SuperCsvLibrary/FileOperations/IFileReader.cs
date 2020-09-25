using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCsvLibrary.FileOperations
{
    internal interface IFileReader
    {
        void ReadFromFile(string fileLocation);
    }
}
