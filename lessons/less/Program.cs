using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less
{
    class Program
    {
        static void Main(string[] args)
        {

            String.Compare("a", "b"); // возвращает -1
            String.Compare("a", "a"); // возвращает 0
            String.Compare("b", "a"); // возвращает 1
            String.Compare("ab", "abc"); // возвращает -1
            String.Compare("Romania", "Russia"); // возвращает -1
            String.Compare("Rwanda", "Russia"); // возвращает 1
            String.Compare("Rwanda", "Romania"); // возвращает 1 

            string s = "Hello, World";
            Console.WriteLine(s.ToUpper()); // выводит "HELLO, WORLD"
            Console.WriteLine(s.ToLower()); // выводит "hello, world"
            Console.ReadLine();
            Console.WriteLine();

            string s = "Hello World";
            Console.WriteLine(s.Insert(5, ",")); // вставляет запятую на 5 позицию 
            Console.ReadLine();

            string s = "Hello, World";
            Console.WriteLine(s.Remove(5)); // удаляем все символы, начиная с 5 позиции, на экран выведется "Hello"
            Console.ReadLine();

            string s = "Arsenal,Milan,Real Madrid,Barcelona";
            string[] array = s.Split(','); // элементы массива – "Arsenal", "Milan", "Real Madrid", "Barcelona"
        }
    }
}
