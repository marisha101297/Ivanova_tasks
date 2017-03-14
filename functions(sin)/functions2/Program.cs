using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions2
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Perimetr(int osnovanieBig, int osnovanieSmal, int high)
{
    int katet = (osnovanieBig - osnovanieSmal) / 2;
    int gipotinyza = (int)(Math.Sqrt(Math.Pow(katet, 2) + Math.Pow(high, 2)));
    int perimetr = osnovanieSmal + osnovanieBig + gipotinyza * 2;
    return perimetr;
}
static void Main(string[] args) 
{
                int sumOfPerimetr = 0;
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Enter the big base of the trapezoid");
                    int osnovanieBig = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the smal base of the trapezoid");
                    int osnovanieSmal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the high of the trapezoid");
                    int high = Convert.ToInt32(Console.ReadLine());
                    int resultOfMethod = Perimetr(osnovanieBig, osnovanieSmal, high);
                    sumOfPerimetr = sumOfPerimetr + resultOfMethod;
                }
                Console.WriteLine(sumOfPerimetr);
            }
        }
    }
}
