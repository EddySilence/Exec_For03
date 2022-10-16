using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //題目：右側對齊星形三角形

            int length = 5;//長度

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(new String(' ', length - i) + new String('*', i));
            }

        }
    }
}
