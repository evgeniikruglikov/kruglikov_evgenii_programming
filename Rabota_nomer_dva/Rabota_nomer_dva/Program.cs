﻿using System;

namespace Rabota_nomer_dva
{
    class Program
    {
        static void Main(string[] args)
        {
            // решение в одну строку
            double answer1 = (Math.Pow(((((85 + 7.0 / 30) - (83 + 5.0 / 18)) / Math.Pow(2 + 2.0 / 3, 1.0 / 3)) / 0.04), 1.0 / 2) + (((140 + 7.0 / 30) - (138 + 5.0 / 12)) / (18 + 1.0 / 6) / (0.02 + 1.0 / 5))) * (1.0 / 3) - Math.Pow(1.0 / 3, 1.0 / 3);
            
            // корень из дроби
            double a1 = (85 + 7.0 / 30) - (83 + 5.0 / 18);
            double a2 = Math.Pow(2 + 2.0 / 3, 1.0 / 3);
            double a3 = a1 / a2;
            double a4 = a3 / 0.04;
            double a5 = Math.Pow(a4, 1.0 / 2);

            // вторая дробь
            double a6 = (140 + 7.0 / 30) - (138 + 5.0 / 12);
            double a7 = a6 / (18 + 1.0 / 6);
            double a8 = a7 / (0.02 + 1.0 / 5);

            // сложение дробей
            double a9 = a5 + a8;

            // умножение на дробь
            double a10 = a9 * (1.0 / 3);

            // вычитание корня
            double answer11 = a10 - Math.Pow(1.0 / 3, 1.0 / 3);

            Console.WriteLine("Вывод решения ответа при решении в одну строку: " + answer1);
            Console.WriteLine("Вывод решения ответа при разбивании выражения на части: " + answer11);
            Console.Read();
        }
    }
}
