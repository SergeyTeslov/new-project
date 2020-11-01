using System;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp1
{
    class Program
    {
        static void checkNumber(int numb, string str)
        {
            bool check = false;
            do
            {
                Console.WriteLine(str);

                try
                {

                    int x = int.Parse(Console.ReadLine());


                    if (numb < 0) { throw new NewException("значение меньше нуля "); }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Ошибка! Введено не число");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Введите целое число больше нуля!");
                    check = true;
                }
            }
            while (check);

        }
        FileReaderException  NewException()
        {
            string description = "My NewFileIOException Description";

            return new FileReaderException(description);
        }
        static void Generation() { }
        static void Main(string[] args)
        {


            Console.WriteLine("Введите размеры массива");


            int numberOfLines = 0;
            int numberOfColumns = 0;

            checkNumber(numberOfLines, "Количество строк");
            checkNumber(numberOfColumns, "Количество столбцов");

            int[,] arr = new int[numberOfLines, numberOfColumns];
        }
    }
}
