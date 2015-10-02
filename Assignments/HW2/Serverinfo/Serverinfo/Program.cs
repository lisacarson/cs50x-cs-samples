using System; 
using System.Text;
using System.Threading.Tasks;

namespace Serverinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Machine = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Environment.MachineName);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Number of Processors = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( Environment.ProcessorCount);
            if (Environment.Is64BitProcess)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("64bit or 32bit = ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The OS is 64bit");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("64bit or 32bit = ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The OS is 64bit");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("OS Version = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Environment.OSVersion.Version.ToString() + "\n");
            Console.ReadLine();
            Console.ResetColor();
        }

        
    }
}
