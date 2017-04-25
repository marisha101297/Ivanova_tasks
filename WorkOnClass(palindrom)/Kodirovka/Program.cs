﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodirovka
{
    class Program
    {
        static char[,] Code(string text)
        {
            Random get = new Random();

            char[] array = new char[text.Length];
            int[,] mass = new int[text.Length, 2];
            char[,] mas = new char[text.Length, 2];


            for (int i = 0; i < text.Length; i++)
            {
                array[i] = Convert.ToChar(text[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                mass[i, 0] = (int)array[i];
                mass[i, 1] = get.Next(10);
                mass[i, 0] = mass[i, 0] + mass[i, 1];
            }

            for (int i = 0; i < text.Length; i++)
            {
                mas[i, 0] = Convert.ToChar(mass[i, 0]);
                mas[i, 1] = Convert.ToChar(mass[i, 1]);
            }

            return mas;
        }

        static char[] Decode(char[,] Code)
        {
            int[] mass = new int[Code.Length / 2];
            char[] mas = new char[Code.Length / 2];

            for (int i = 0; i < Code.Length / 2; i++)
            {
                // erre[i,0] = (int)Kod[i,0];
                mass[i] = (int)Code[i, 0] - (int)Code[i, 1];
            }

            for (int i = 0; i < Code.Length / 2; i++)
            {
                mas[i] = Convert.ToChar(mass[i]);
            }

            return mas;
        }


        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Marishka\Desktop\Евтушенко.txt");

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(Code(text)[i, 0]);
            }

            Console.Write("\r\n");

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(Decode(Code(text))[i]);
            }

            Console.ReadKey();
        }
    }
}
