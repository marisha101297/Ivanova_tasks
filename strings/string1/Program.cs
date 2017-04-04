using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\Марина.txt");

            Console.WriteLine(text);
            string unikum = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (IfBykvaUnikum(text[i], unikum))

                    unikum = unikum + text[i];

            }
            Console.WriteLine(unikum);

            string[] textMass = text.Split(' ');
            Console.WriteLine("Количество слов:" + textMass.Length);
            System.IO.File.WriteAllText(@"C:\Users\Marishka\Desktop\игры.txt", "Количество слов:" + textMass.Length);

            Console.WriteLine("Кол-во символов в тексте = " + text.Length);

            Console.WriteLine("Количество буквы " + Counter(text, "а"));
            double count = Counter(text, "а");
            double all = text.Length;

            Console.WriteLine("Процентное соотношение буквы ко всем символам = " + ProcentSootnochenie(all, count));
            Console.WriteLine();


            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            System.IO.File.WriteAllText(@"C:\Users\Marishka\Desktop\игры.txt", text + "\r\n" +
            "\r\n" + "Количество слов:" + textMass.Length + "\r\n"
            + "Процентное соотношение буквы ко всем символам = " +
            +ProcentSootnochenie(all, count) + "\r\n"
            + "Кол-во символов в тексте = " + text.Length + "\r\n" + "\r\n" +
            text.ToLower() + text.ToUpper());



        }
        static int Counter(string b, string a)
        {
            int count = 0;


            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == a[0])
                {
                    count++;
                }

            }
            return count;

        }

        static double ProcentSootnochenie(double all, double count)
        {
            return (count * 100) / all;

        }

        static bool IfBykvaUnikum(char a, string unikum)

        {
            for (int i = 0; i < unikum.Length; i++)
            {
                if ((a == unikum[i]))
                    return false;
            }
            return true;
        }
    }
}
