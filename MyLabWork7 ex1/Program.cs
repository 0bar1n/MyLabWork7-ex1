using System;

namespace MyLabWork7_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a; //переменная десятичного типа
            Console.WriteLine("Двузначное число a="); //просим пользователя ввести число
            a = Convert.ToDecimal(Console.ReadLine()); //задание переменной десятичного типа
            a = Math.Floor(a / 10); // задание переменной по формуле, нахождение числа дeсятков в ней 
            Console.WriteLine($"Число десятков в числе а равно {a}"); //вывод на экран 
        }
    }
}
