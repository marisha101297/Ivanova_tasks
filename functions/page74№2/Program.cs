using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page74_2
{
    class Program
    {
        static double Vichislenie(double chislitel)
        {
            double result = ((chislitel + Math.Sin(chislitel)) / 3);
            return result;
        }
        static void Main(string[] args)
        {
            double y = 0;
            double chislitel = 1;
            for (int i = 0; i < 3; i++)
            {
                double resultOfMethod = Vichislenie(chislitel);
                y = y + resultOfMethod;
                chislitel += 2;
            }

            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
