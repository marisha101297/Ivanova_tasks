using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatime
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\даты.txt");
            string[] count = text.Split(new char[] { '\r' });
            DateTime[] data = new DateTime[count.Length];
            for (int i = 0; i < count.Length; i++)
            {
                data[i] = DateTime.Parse(count[i]);
            }

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            for (int i = 0; i < data.Length; i++)
                for (int j = 0; j < data.Length - 1; j++)
                    if (data[j] > data[j + 1])
                    {
                        DateTime t = (data[j + 1]);
                        data[j + 1] = data[j];
                        data[j] = t;
                    }
            Console.WriteLine('\n');

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

            Console.WriteLine('\n');
            Console.WriteLine("Самая ранняя дата из списка это - {0} \r\nСамая позняя дата из списка это - {1}", data[0], data[data.Length - 1]);

            Console.ReadKey();
        }
    }
}
