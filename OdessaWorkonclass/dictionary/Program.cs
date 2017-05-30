using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace dictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\теекст.txt");
            Console.WriteLine("Текст: \r\n" + text);
            string Text = text.ToLower();
            string NewText = Regex.Replace(Text, "[.?!)(,:;«»—\r\n]", "");
            Console.WriteLine(NewText);
            string[] WordsInText = NewText.Split(new char[] { ' ' });


            var dictionary = new Dictionary<string, int>();
            //int unic = 0; 
            for (int i = 0; i < WordsInText.Length; i++)
            {
                string symbols = WordsInText[i];
                if (symbols != " ")
                {
                    if (!dictionary.ContainsKey(symbols))
                    {
                        dictionary[symbols] = 1;
                    }
                    else
                    {
                        dictionary[symbols]++;
                    }
                }
            }

            //Console.WriteLine("Количество уникальных слов: " + unic); 
            foreach (var e in dictionary)
            {
                Console.WriteLine("Слово: " + e.Key + "\t\r\n" +  "В тексте встречается " + e.Value + "раз");
            }


            Console.ReadKey();
        }
    }
}

