using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulearn
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[6];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            arr[5] = 6;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (i + 1) * 2;               
            }
            foreach (var e in arr)
                Console.WriteLine(e);
            //return arr;
           // Console.WriteLine(arr);
            Console.ReadLine();

        }
    }
}
