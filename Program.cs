using System;
namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задачи на одномерный массив");
            Console.WriteLine();
            Console.WriteLine("Введите длину массива:");
            int length = int.Parse(Console.ReadLine());
            bool randi = false;
            Console.WriteLine();
            Console.WriteLine("Ввести массив с клавиатуры Да/Нет?");
            if (Console.ReadLine() == "Да")
            {
                randi = true;
            }
            One_dimension Array = new One_dimension(length, randi);
            Array.Print();
            Console.WriteLine();
            Array.Getmiddle();
            Array.Remove_More_Than_100();

            Console.WriteLine("Двумерные массивы");
            Console.WriteLine("Введите количество строк:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите количество столбцов:");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool randi2 = false;
            Console.WriteLine();
            Console.WriteLine("Ввести массив с клавиатуры Да/Нет?");
            if (Console.ReadLine() == "Да")
            {
                randi2 = true;
            }

            Two_dimension Array2 = new Two_dimension(rows, columns, randi2);
            Array2.Print();
            Console.WriteLine();
            Console.WriteLine();
            Array2.Getmiddle();
            Array2.Print2();
            Console.WriteLine("Задачи на зубчатый массив");
            Console.WriteLine();
            Console.WriteLine("Введите количество массивов:");
            int Len = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool randi3 = false;
            Console.WriteLine();
            Console.WriteLine("Ввести массив с клавиатуры Да/Нет?");
            if (Console.ReadLine() == "Да")
            {
                randi3 = true;
            }
            Jagged Array3 = new Jagged(Len, randi3);
            Array3.Print();
            Console.WriteLine();
            Console.WriteLine();
            Array3.Center();
        }
    }
}