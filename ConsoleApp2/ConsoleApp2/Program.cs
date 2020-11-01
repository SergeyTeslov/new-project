using System;

namespace ConsoleApp2
{
    class Program
    {

        //генерация массива случайными числами в необходимом диапазоне
        static int[,] generationMassive(int[,] massive, int x, int y, int lowerLimit, int upperLimit)
        {
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    massive[i, j] = rnd.Next(lowerLimit, upperLimit + 1);


                }
            }
            return massive;
        }
        //вывод на консоль получившегося массива
        static void PrintMatrix(int[,] massive, int x, int y, int lowerLimit, int upperLimit)
        {

            string format;
            if (upperLimit >= (-lowerLimit) && (int)Math.Log10(upperLimit) + 1 > 2)
                format = "{0," + ((int)Math.Log10(upperLimit) + 3) + "}";
            else if (upperLimit < (-lowerLimit) && (int)Math.Log10(-lowerLimit) + 1 > 2)
                format = "{0," + ((int)Math.Log10(-lowerLimit) + 3) + "}";
            else
                format = "{0,4}";
            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < x; i++) // заполнение и вывод матрицы
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(String.Format(format, massive[i, j]));

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int exit = 0;
            int x = 10;
            int y = 10;
            int lowerLimit = -10;
            int upperLimit = 10;
            int[,] massive = new int[x, y];

            do
            {
                massive = generationMassive(massive, x, y, lowerLimit, upperLimit);
                PrintMatrix(massive, x, y, lowerLimit, upperLimit);

                Console.WriteLine("сгенерировать ещё раз? (введите 1)");
                try
                {
                    exit = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException) {
                    Console.WriteLine("выход из программы");
                    return; 
                }

            } while (exit == 1);
        }
    }
}
