using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static string DisplayMessage()
        {
            return "Hello World";
        }
        public static string DisplayName()
        {
            return "Jude Kc";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayMessage());
            Console.WriteLine(DisplayName());
        }
    }
}
