using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serverinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Machine = " + Environment.MachineName);
            Console.WriteLine("Number of Processors = " + Environment.ProcessorCount);
            if (Environment.Is64BitProcess)
                Console.WriteLine("64bit or 32bit = The OS is 64bit");
            else
                Console.WriteLine("64bit or 32bit = The OS is 32bit");

            Console.WriteLine("OS Version = " + Environment.OSVersion.Version.ToString() + "\n");
            Console.ReadLine();
        }

        
    }
}
