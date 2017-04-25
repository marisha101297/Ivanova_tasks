using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOnClass
{
    class Program
    {

        static bool Palindrom(string slovo)
        {


            int s = 0;
            char[] arra = new char[slovo.Length];

            for (int i = 0; i < slovo.Length; i++)
            {
                arra[i] = slovo[i];
            }

            for (int i = 0; i < slovo.Length / 2; i++)
            {
                if (arra[i] == arra[arra.Length - (1 + i)])
                {
                    s++;
                }
                else
                {
                    //Console.WriteLine("НЕ Палиндром");
                    break;
                }
            }
            if (s == slovo.Length / 2 & (slovo != ""))
                Console.WriteLine("Палиндром  {0}", slovo);

            

            return true;
        }


        static void Main(string[] args)
        {


            string str = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\Евтушенко.txt");

            string[] arr = str.Split(new Char[] { ' ', '-', '"', ',', '.', ':', '\r', '\t', '!', '?', ';', '\n', '\0', });
            // string[] arr = str.Split(new char[] { ' ', ';', '-', '_', '@', '>', '<', '.' });


            for (int i = 0; i < arr.Length; i++)
            {
                Palindrom(arr[i]);
            }

            Console.ReadKey();
        }
    }
}

