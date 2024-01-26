using System;
namespace Task3_1
{
	class One_dimension
	{
        private int[] array;
        public One_dimension(int length, bool randi)
        {
            array = new int[length];

            if (randi)
            {
                Fill_array();
            }
            else
            {
                Fill_array_random();
            }
        }

        public void Createarray(int length, bool randi)
        {
            array = new int[length];

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
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                array[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine();

        }

        private void Fill_array_random()
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-200, 200);
            }
            Console.WriteLine();
        }

        public void Getmiddle()
        {
            decimal suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            decimal result = suma / array.Length;

            Console.WriteLine("Средние значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        public void Remove_More_Than_100()
        {
            Console.WriteLine("Массив после удаления чисел, более 100 по модулю:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    Console.Write($"{array[i]}, ");
                }
            }

            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine("Начальный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
    }
}


