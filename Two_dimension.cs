using System;
namespace Task3_1
{
	class Two_dimension
	{
        private int[,] array;
        public Two_dimension(int rows, int columns, bool randi2)
        {
            array = new int[rows, columns];
            if (randi2)
            {
                Fill_array();
            }
            else
            {
                Fill_array_random();
            }
        }
        public void Createarray(int rows, int columns, bool randi)
        {
            array = new int[rows, columns];

            if (randi)
            {
                Fill_array();
            }
            else
            {
                Fill_array_random();
            }

        }
        private void Fill_array()
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент массива:");

                    array[i, j] = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        private void Fill_array_random()
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-250, 250);
                }
            }
            Console.WriteLine();
        }

        public void Getmiddle()
        {
            decimal sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            decimal result = sum / (array.GetLength(0) * array.GetLength(1));
            Console.WriteLine("Среднее значение массива:");
            Console.WriteLine(result);
            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Print2()
        {
            Console.WriteLine("Массив с перевернутыми строками:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = array.GetLength(1); j > 0; j--)
                    {
                        Console.Write(array[i, j-1] + " ");
                    }
                }
                else
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                         Console.Write(array[i, k] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}

