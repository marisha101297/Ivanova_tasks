using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odessa
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Покупатель.txt");
            Console.WriteLine("Текст: \r\n" + text);
            string[] date = text.Split(new char[] { '.' });

            for (int i = 0; i < date.Length - 1; i++)
            {
                string NewDate = date[i];
                string[] parts = date[i].Split(new char[] { ';' });

                string[] adress = parts[9].Split(new char[] { ',' });
                if (adress[4] == " Одесса")
                {
                    Console.WriteLine("Фамилия:{0}\r\nИмя:{1}\r\nОтчество:{2}\r\nПол:{3}\r\nНациональность:{4}\r\nРост:{5}\r\nВес:{6}\r\nДата рождения:{7}\r\nНомер телефона:{8}\r\nДомашний адрес:{9}\r\n ", parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8], parts[9]);
                }
            }

            Console.ReadKey();
        }
    }
}
