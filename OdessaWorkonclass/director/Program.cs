using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace director
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\кинолента.txt");
            Console.WriteLine("Текст: \r\n" + text);
            string[] date = text.Split(new char[] { '.' });

            for (int i = 0; i < date.Length - 1; i++)
            {
                string NewDate = date[i];
                string[] parts = date[i].Split(new char[] { ';' });

                //string[] adress = parts[1].Split(new char[] { ',' });
                if (parts[1] == " Ежи Гоффман")
                {
                    Console.WriteLine("Название:{0}\r\nРежиссер:{1}\r\nГод Выхода:{2}\r\nСтрана:{3}\r\nСтоимость:{4}\r\nДоход:{5}\r\nПрибыль:{6}\r\n", parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]);
                }
            }

            Console.ReadKey();
        }
    }
}
