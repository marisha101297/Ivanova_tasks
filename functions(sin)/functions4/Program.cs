using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions4
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
            double peremennayaVChislitele = 2, peremennayaVZnamenatele = 5;
            double resultOfMethod = Vichislenie(peremennayaVChislitele, peremennayaVZnamenatele);
            double y = 0;
            y = y + resultOfMethod;
            peremennayaVChislitele = 6;
            peremennayaVZnamenatele = 3;
            resultOfMethod = Vichislenie(peremennayaVChislitele, peremennayaVZnamenatele);
            y = y + resultOfMethod;
            peremennayaVChislitele = 1;
            peremennayaVZnamenatele = 4;
            resultOfMethod = Vichislenie(peremennayaVChislitele, peremennayaVZnamenatele);
            y = y + resultOfMethod;
            Console.WriteLine(y);
            // 5 номер 
        }
    }
}
