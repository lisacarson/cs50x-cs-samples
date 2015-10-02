using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToShortDateString());
            Console.WriteLine(currentTime.ToLongDateString());
            Console.WriteLine(currentTime.ToShortTimeString());
            Console.WriteLine(currentTime.ToLongTimeString());
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
