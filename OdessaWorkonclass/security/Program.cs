using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security
{
    struct Birthday
    {
        public int day;
        public int month;
        public int year;
    }

    class Program
    {

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\телохранитель.txt");
            Console.WriteLine("Текст: \r\n" + text);
            string[] date = text.Split(new char[] { '.' });
            string[] parts = text.Split(new char[] { ';' });

            Birthday[] dates = new Birthday[date.Length];

            for (int i = 0; i < date.Length; i++)
            {
                string[] chislo = date[i].Split(',');
                dates[i].day = Convert.ToInt32(chislo[0]);
                dates[i].month = Convert.ToInt32(chislo[1]);
                dates[i].year = Convert.ToInt32(chislo[2]);
            }
            
            for (int i = 0; i < dates.Length; i++)
            {
                Console.WriteLine("{0} , {1} , {2}", dates[i].day, dates[i].month, dates[i].year);
            }
            Console.ReadKey();
        }
    }
}

