using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions3
{
    class Program
    {
        static int LongSides(int x1, int x2, int y1, int y2)
        {
            int tempX = x2 - x1, tempY = y2 - y1;
            int sides = (int)Math.Sqrt(Math.Pow(tempX, 2) + Math.Pow(tempY, 2));
            return sides;
        }
        static void Main(string[] args)
        {
            //Программа определения периметра треугольника, заданного координатами его вершин.

            Console.WriteLine("Enter the first coordinate of the point 'a' ");
            int ax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point 'a' ");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first coordinate of the point 'b' ");
            int bx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point 'b' ");
            int by = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first coordinate of the point 'c' ");
            int cx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point 'c' ");
            int cy = Convert.ToInt32(Console.ReadLine());
            int ab = LongSides(ax, ay, bx, by);
            int bc = LongSides(bx, by, cx, cy);
            int ca = LongSides(cx, cy, ax, ay);
            int perimeter = ab + bc + ca;
            Console.WriteLine(perimeter);

            // 11 номер
        }
    }
