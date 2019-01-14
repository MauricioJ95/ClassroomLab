using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generateor!");
            string input;
            double p;
            double a;
            double v;

            do
            {
                Console.WriteLine("Enter Length:");
                string length = Console.ReadLine();
                double l = double.Parse(length);

                Console.WriteLine("Enter Width:");
                string width = Console.ReadLine();
                double w = double.Parse(width);

                Console.WriteLine("Enter Height:");
                string height = Console.ReadLine();
                double h = double.Parse(width);

                a = l * w;
                Console.WriteLine("Area: " + a);

                p = 2 * l * +2 * w;
                Console.WriteLine("Perimeter: " + p);

                v = l * w * h;
                Console.WriteLine("Volume:" + v);

                Console.WriteLine("Continue? (y/n):");
                input = Console.ReadLine();
            }
            while (input == "y");
        }
    }
}
