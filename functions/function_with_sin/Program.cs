using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_with_sin
{
    class Program
    {
        static double Vichislenie(double Chislitel, double Znamenatel)
        {
            double result = (Chislitel + Math.Sin(Chislitel)) / (Math.Sin(Znamenatel) + Znamenatel);
            return result;
        }

        static void Main(string[] args)
        {
            double peremennayaVchislitele = 2, peremennayaVznamenatele = 5;
            double resultOfMethod = Vichislenie(peremennayaVchislitele, peremennayaVznamenatele);

            double y = 0;

            y = y + resultOfMethod;
            peremennayaVchislitele = 6;
            peremennayaVznamenatele = 3;
            resultOfMethod = Vichislenie(peremennayaVchislitele, peremennayaVznamenatele);
            y = y + resultOfMethod;
            peremennayaVchislitele = 1;
            peremennayaVznamenatele = 4;
            resultOfMethod = Vichislenie(peremennayaVchislitele, peremennayaVznamenatele);
            y = y + resultOfMethod;
            Console.WriteLine(y);
 


        }
    }
}
