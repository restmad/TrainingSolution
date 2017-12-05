using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Security.Md5;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abcdefg ";
            string md5 = Md5Helper.GetMd5(text);
            Console.WriteLine(md5);
            Console.ReadKey();
        }
    }
}
