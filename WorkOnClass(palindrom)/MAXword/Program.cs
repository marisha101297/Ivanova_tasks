using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAXword
{
    class Program
    {
        static void Main(string[] args)
        {

                string str = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\Евтушенко.txt");

                string[] arr = str.Split(new Char[] { ' ', ',', '.', ':', '\n', '\t', '!', '?', ';', '\r'});
            
                string max = "";
                string clovo = "";
                string min = "";
                string slovo = "sinchrophasotron";

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length == clovo.Length)
                    {
                        max = max + " " + arr[i];
                    }
                    if (arr[i].Length > clovo.Length)
                    {
                        clovo = arr[i];
                        max = clovo;
                    }




                    if ((arr[i].Length == slovo.Length) & (arr[i].Length == 1))
                    {
                        min = min + " " + arr[i];
                    }
                    if (arr[i].Length < slovo.Length)
                    {
                        slovo = arr[i];
                        min = slovo;
                    }
                }

                string[] maax = max.Split(new Char[] { ' ', ',', '.', ':', '\n', '\t', '!', '?', ';', '\r' }); 
                string[] miin = min.Split(new Char[] { ' ', ',', '.', ':', '\n', '\t', '!', '?', ';', '\r' });

            //{ ' ', ',', '.', ':', '\r', '\t', '!', '?', ';' }

            Console.WriteLine("Количество слов в тексте");
                Console.WriteLine(arr.Length);
                Console.WriteLine("количество мах слов");
                Console.WriteLine(maax.Length);
                Console.WriteLine(max);
                Console.WriteLine("количество min слов");
                Console.WriteLine(miin.Length);
                Console.WriteLine(min);


                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.ReadKey();
            
        }
    }
}
