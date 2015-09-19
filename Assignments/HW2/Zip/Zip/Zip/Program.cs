using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Zip
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"C:\Users\Lisa\Documents\cs50x-cs-samples\Assignments\Zip\Tobezipped";
            string zipPath = @"C:\Users\Lisa\Documents\cs50x-cs-samples\Assignments\Zip\Zippedto";
            

            ZipFile.CreateFromDirectory(startPath, zipPath);

          
        }
    }
}
