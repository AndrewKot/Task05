using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            //int a = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(Convert.ToString(a << 1));

            int b = 0b_0000_0000_0000_0000_0000_0000_0000_0100;
            b = b << 10;
            Console.WriteLine(Convert.ToString(b, 2));

            float f = 12f;


            Console.ReadLine();
        }
    }
}
