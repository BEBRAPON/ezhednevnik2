using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> zam1 = new List<string> {"1)Высрать пон.\r\n  2)Высрать непон." };
            foreach (string i in zam1)
            {
                Console.WriteLine("  " + i);
            }
        }
    }
}
