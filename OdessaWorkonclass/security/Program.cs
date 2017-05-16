using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\телохранитель.txt");
            Console.WriteLine("Текст: \r\n" + text);

            //string[] strs = text.Split(new char[] { '.' });
            //Birthday[] dates = new Birthday[date.Length]; 
            string[] strs = text.Split(';');

            for (int i = 0; i < strs.Length - 1; i++)
            {
                string[] parts = strs[i].Split(new char[] { '.' });
                //string[] chislo = parts[11].Split(new char[] { ',' }); 
            }

            DateTime min = DateTime.MaxValue;
            int it = 0;
            //DateTime tmp = Convert.ToDateTime(Convert.ToString(strs[11]));
            for (int i = 0; i < strs.Length - 1; i += 12)
            {
                DateTime tmp = Convert.ToDateTime(Convert.ToString(strs[i+11]));
                if (tmp < min)
                {
                    min = tmp;
                    //min = Convert.ToDateTime(Convert.ToString(strs[i + 11]));
                    it = i;
                }
            }
            Console.WriteLine("Фамилия:{0}\r\nИмя:{1}\r\nОтчество:{2}\r\nИндекс:{3}\r\nСтрана:{4}\r\nОбласть:{5}\r\nРайон:{6}\r\nГород:{7}\r\nУлица:{8}\r\nДом: {9}\r\nКвартира: {10}\r\nДата Рождения: {11}\r\n ", strs[it], strs[it+1], strs[it + 2], strs[it + 3], strs[it + 4], strs[it + 5], strs[it + 6], strs[it + 7], strs[it + 8], strs[it + 9], strs[it + 10], strs[it + 11]);
            Console.ReadKey();





            //string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\телохранитель.txt");
            //Console.WriteLine("Текст: \r\n" + text);
            ////string[] date = text.Split(new char[] { '.' });
            //string[] strs = text.Split(new char[] { ';' });
            ////string[] strs = text.Split(';');

            //for (int i = 0; i < strs.Length - 1; i++)
            //{
            //    string[] parts = strs[i].Split(new char[] { ';' });
            //    //string[] chislo = parts[11].Split(new char[] { ',' }); 
            //}

            //DateTime min = DateTime.MaxValue;
            //int j = 0;
            //for (int i = 0; i < strs.Length - 1; i += 12)
            //{
            //    DateTime tmp = Convert.ToDateTime(Convert.ToString(strs[i + 11]));
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //        j = i;
            //    }
            //}
            //Console.WriteLine("Фамилия:{0}\r\nИмя:{1}\r\nОтчество:{2}\r\nИндекс:{3}\r\nСтрана:{4}\r\nОбласть:{5}\r\nРайон:{6}\r\nГород:{7}\r\nУлица:{8}\r\nДом: {9}\r\nКвартира: {10}\r\nДата Рождения: {11}\r\n ", strs[0], strs[1], strs[2], strs[3], strs[4], strs[5], strs[6], strs[7], strs[8], strs[9], strs[10], strs[11]);
            //Console.ReadKey();



            //for (int i = 0; i < date.Length; i++)
            //{
            //    string[] chislo = date[i].Split(',');
            //    dates[i].day = Convert.ToInt32(chislo[0]);
            //    dates[i].month = Convert.ToInt32(chislo[1]);
            //    dates[i].year = Convert.ToInt32(chislo[2]);
            //}

            //for (int i = 0; i < dates.Length; i++)
            //{
            //    Console.WriteLine("{0} , {1} , {2}", dates[i].day, dates[i].month, dates[i].year);
            //}
            //Console.ReadKey();
        }
    }
}

