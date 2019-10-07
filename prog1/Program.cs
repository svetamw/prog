using System;

namespace prog1
{
    class MainClass
    {
        public static void Main()
        {
            Console.Write("x1 = ");
            string x1str = Console.ReadLine();
            Console.Write("x2 = ");
            string x2str = Console.ReadLine();
            //Console.Write("dx = ");
            //string dxstr = Console.ReadLine();

            double x1 = double.Parse(x1str);
            double x2 = double.Parse(x2str);
            //double dx = double.Parse(dxstr);

            //int N = (int)((x2 - x1) / dx);
           // N++;


            //double x = (x2 + x1) / 2;
            double k = 0.5 * ((x2 - x1) * ((x1 * x1) + (x2 * x2)));
            Console.WriteLine($"x2 = {((x1 - x2) * ((x1 * x1) + (x2 * x2))):f3}");
            //Console.WriteLine($"x1 = {x1:f3}");

            Console.WriteLine($"f = {k:f3}");
        }
    }
}
