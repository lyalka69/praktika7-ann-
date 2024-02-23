using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetWindowSize(125, 50);

            Console.Title = "Сакара - Компьютерный практикум № 7";


            //Задание 1.Определить, является или нет текущий год високосным? Год ввести с клавиатуры.
            ///
            //Console.Write("Введите год: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 4 == 0)
            //{
            //    Console.Write($"Является високосным годом");
            //}
            //else
            //{
            //    Console.Write($"Не является високосным годом");
            //}
            //Console.ReadKey();

            //Задание 2.Определить, входит ли цена выбранного ноутбука в диапазон от 20 до 30 тыс.р.
            
            //Console.Write("Введите цену ноутбкука: ");
            //int a = int.Parse(Console.ReadLine());

            //string c = 20000 <= a && a <= 30000 ? "ноутбук входит в диапозон от 20 до 30 тыс. р." :  "ноутбук не входит в диапозон от 20 до 30 тыс. р.";
            //Console.WriteLine(c);
            //if (20000 <= a && a <= 30000)
            //{
            //    Console.Write("ноутбук входит в диапозон от 20 до 30 тыс. р.");
            //}
            //else
            //{
            //    Console.Write("ноутбук не входит в диапозон от 20 до 30 тыс. р.");
            //}
            //Console.ReadKey();

            //Задание 3. Написать программу, которая в зависимости от заданного балла определяет оценку учащегося согласно таблице:

            //Console.Write("Введите ваш балл: ");
            //int a = int.Parse(Console.ReadLine());
            //if ( 0 <= a && a < 60 ) 
            //{
            //    Console.Write("ваша оценка - неудовлетворительная");
            //}
            //else if (60 <= a && a <= 74) 
            //{
            //    Console.Write("ваша оценка - удовлетворительная");
            //}
            //else if (75 <= a && a <= 89)
            //{
            //    Console.Write("ваша оценка - хорошая");
            //}
            //else if (90 <= a && a <= 100)
            //{
            //    Console.Write("ваша оценка - отличная");
            //}
            ////if (0 <= a && a < 60) Console.Write("ваша оценка - неудовлетворительная");
            ////if (60 <= a && a <= 74) Console.Write("ваша оценка - удовлетворительная");
            ////if (75 <= a && a <= 89) Console.Write("ваша оценка - хорошая");
            ////if (90 <= a && a <= 100) Console.Write("ваша оценка - отличная");
            //Console.ReadKey();


            //Задание 4. Вычислить значение функции при целых аргументах:

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //double f = 0;
            //if (x >= 0)
            //{
            //    f = 2 * x + Math.Sqrt(x);
            //    //Console.Write($"f= {2 * x + Math.Sqrt(x)}");
            //}
            //else if (x < 0)
            //{
            //    f = Math.Abs(x) + Math.Pow(x, 2);
            //    //Console.Write($"f= {Math.Abs(x) + Math.Pow(x, 2)}");
            //}
            //Console.WriteLine(f);
            //Console.ReadKey();

            Console.Title = "Сакара - Самостоятельная работа № 1.";

            //Составить программный код вычисления функции с использованием полного условного оператора для целых аргументов (выполнить минимум 2 прогона работы программы).

            //Задание 1.1

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());

            //double z = 0;
            //if (x >= 0)
            //{
            //    z = 2 + 3 * Math.Sqrt(x);
            //    //Console.Write($"z= {2 + 3 * Math.Sqrt(x)}");
            //}
            //else if (x < 0)
            //{
            //    //Console.Write($"z= {1 - 2 * Math.Pow(x, 2)}");
            //    z = 1 - 2 * Math.Pow(x, 2);
            //}
            //Console.WriteLine(z);
            //Console.ReadKey();

            //Задание 1.2

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //double t = 0;
            //if (x >= 0)
            //{
            //    t = Math.Sin(x);
            //    //Console.Write($"t= {Math.Sin(x)}"); 
            //}
            //else if (x < 0)
            //{
            //    t = Math.Abs(Math.Pow(x, 3));
            //    //Console.Write($"t= {Math.Abs(Math.Pow(x, 3))}");
            //}
            //Console.WriteLine(t);
            //Console.ReadKey();

            //Задание 1.3

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write($"y= {((3 * Math.Pow(x, 2) + 4) * (Math.Pow(x, 2) - 4)) / (Math.Pow(x, 2) - 81)}"); 
            //Console.ReadKey();

            //Задание 1.4

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x >= 0)
            //{
            //    Console.Write($"y= {Math.Sqrt(Math.Pow(x, 2) - 1)}"); 
            //}
            //else if (x < 0)
            //{
            //    Console.Write($"y= {Math.Pow(x, 2) + 25}");
            //}
            //Console.ReadKey();

            //Задача 1.5

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write($"y= {(4 / (2 * x + 10)) + (1 / (3 * x - 9))}");
            //Console.ReadKey();

            //Задача 1.6

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x >= 0)
            //{
            //    Console.Write($"s= {2 * Math.Pow(x, 2) + 5}"); 
            //} 
            //else if (x < 0)
            //{
            //    Console.Write($"s= {-3 * Math.Pow(x, 2)}");
            //}
            //Console.ReadKey();

            //Задача 1.7

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x >= 0)
            //{
            //    Console.Write($"f= {2 * x + Math.Sqrt(x)}");
            //}
            //else if (x < 0)
            //{
            //    Console.Write($"f= {Math.Abs(x) + Math.Pow(x,2)}");
            //}
            //Console.ReadKey();    

            //Задача 1.8

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());

            //double y = x >= 0 ? Math.Sqrt(x) + 2 * Math.Sin(x) : 6 - Math.Pow(x, 2);
            //if (x >= 0)
            //{
            //    Console.Write($"y= {Math.Sqrt(x) + 2 * Math.Sin(x)}");
            //}
            //else if (x < 0)
            //{
            //    Console.Write($"y= {6 - Math.Pow(x, 2)}");
            //}
            //Console.ReadKey();

            Console.Title = "Сакара - Компьютерный практикум № 7";

            //Задача 5. Вычислить значение функции при вещественных аргументах:

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //double x = double.Parse(Console.ReadLine());
            //Console.WriteLine(f);
            //if (x <= -5)
            //{
            //    Console.Write($"f(x)= {Math.Sqrt(13 - x)}");
            //}
            //else if (-5 < x && x < 5)
            //{
            //    Console.Write($"f(x)= {Math.Abs(4 * x - 5)}");
            //}
            //else if (x >= 5)
            //{
            //    Console.Write($"f(x)= {3 *  Math.Pow(x,2) - 5 * x}");
            //}
            //Console.ReadKey();

            Console.Title = "Сакара - Самостоятельная работа № 2.";
            //Самостоятельная работа № 2. Составить программный код вычисления функции с использованием неполного и вложенного условного оператора (выполнить минимум 3 прогона работы программы).

            //Вариант 1.

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x <= -5)
            //{
            //    Console.Write($"f(x)= {3 * Math.Pow(x, 2) - 5 * x}");
            //}
            //else if (-5 < x && x < 5)
            //{
            //    Console.Write($"f(x)= {Math.Abs(4 * x - 5)}");
            //}
            //else if (x >= 5)
            //{
            //    Console.Write($"f(x)= {Math.Sqrt(13 - x)}");
            //}
            //Console.ReadKey();

            //Вариант 2.

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x <= -5)
            //{
            //    Console.Write($"f(x)= {Math.Pow(x, 2) + 15 * x}");
            //}
            //else if (x >= 5)
            //{
            //    Console.Write($"f(x)= {(3 * x + 1) / 5}");
            //}
            //else
            //{
            //    Console.Write($"f(x)= {Math.Sqrt(13 + x)}");
            //}
            //Console.ReadKey();

            //Вариант 3.

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());

            //if (0 <= x && x < 5)
            //{
            //    Console.Write($"f(x)= {2 * x}");
            //}
            //if (5 <= x && x < 10)
            //{
            //    Console.Write($"f(x)= {x}");
            //}
            //if (10 < x || x < 0)
            //{
            //    Console.Write($"f(x)= 0");
            //}
            //Console.ReadKey();

            //Вариант 4.

            //Console.Write("Введите число: ");
            //int x = int.Parse(Console.ReadLine());
            //if (x < -5)
            //{
            //    Console.Write($"f(x)= {12 + Math.Sqrt(13 - 5 * x)}");
            //}
            //else if (-5 <= x && x <= 5)
            //{
            //    Console.Write($"f(x)= {(Math.Cos(4 * x)) + x / 5}");
            //}
            //else if (x > 5)
            //{
            //    Console.Write($"f(x)= {(Math.Sin(8 * x)) - Math.Abs(x - 12)}");
            //}
            //Console.ReadKey();

        }
    }
}
