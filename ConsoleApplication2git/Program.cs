using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2git
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            Console.WriteLine();
            Console.WriteLine("Hello C#");
            keyInfo = Console.ReadKey();
            Console.WriteLine(keyInfo.KeyChar);
            Console.WriteLine();
            Console.WriteLine("123" + keyInfo.KeyChar);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
