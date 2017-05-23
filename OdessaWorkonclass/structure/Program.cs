using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    class Program
    {
        //Наименование Количество Цена Изготовитель Дата поступления на склад
        //Определить количество всех товаров, количество которых больше 5 и вывести сведения об этих товарах

        public struct store
        {
            public string name, fabricate;
            public int kolichestvo, price;
            public DateTime date;
        }


        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\товары.txt");
            string[] hollow = text.Split(new char[] { '\r', '\t', '\n' });

            List<string> arr = new List<string>();

            for (int i = 0; i < hollow.Length; i++)
            {
                if (hollow[i] != "")
                {
                    arr.Add(hollow[i]);
                }
            }

            store[] goods = new store[5];
            int count = 0;

            for (int i = 0; i < goods.Length; i++)
            {
                goods[i].name = arr[count];
                count++;
                goods[i].kolichestvo = Convert.ToInt32(arr[count]);
                count++;
                goods[i].price = Convert.ToInt32(arr[count]);
                count++;
                goods[i].fabricate = arr[count];
                count++;
                goods[i].date = Convert.ToDateTime(arr[count]);
                count++;
            }

            for (int i = 0; i < goods.Length; i++)
            {
                if (goods[i].kolichestvo >= 5)
                {
                    Console.WriteLine(goods[i].name + "\t" + goods[i].kolichestvo + "\t" + goods[i].price + "\t" + goods[i].fabricate + "\t" + goods[i].date);
                }
            }

            DateTime max = DateTime.MinValue;
            count = 0;
            for (int i = 0; i < goods.Length; i++)
            {
                if (goods[i].date > max)
                {
                    max = goods[i].date;
                    count = i;
                }
            }

            Console.WriteLine();

            Console.WriteLine("Мах дата: {0}", goods[count].name + "\t" + goods[count].kolichestvo + "\t" + goods[count].price + "\t" + goods[count].fabricate + "\t" + goods[count].date);


            Console.ReadKey();

        }
    }
}
