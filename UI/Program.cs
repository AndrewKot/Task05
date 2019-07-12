using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicInterface;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter real value:");

            double a;
            float f;
            int i;

            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(TranslateToBinary.GetDoubleInBit(a));
            Console.WriteLine(TranslateToBinary.GetDoubleInBit2(a));

            string str = Console.ReadLine();
            f = float.Parse(str, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine(f);
            Console.WriteLine(TranslateToBinary.GetDoubleInBit(f));
            Console.WriteLine(TranslateToBinary.GetDoubleInBit2(f));

            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TranslateToBinary.GetDoubleInBit(i));
            Console.WriteLine(TranslateToBinary.GetDoubleInBit2(i));

            Console.ReadLine();
        }
    }
}
