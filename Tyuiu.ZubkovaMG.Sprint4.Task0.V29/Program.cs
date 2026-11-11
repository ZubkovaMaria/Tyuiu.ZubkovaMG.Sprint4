using Tyuiu.ZubkovaMG.Sprint4.Task4.V29.Lib;
namespace Tyuiu.ZubkovaMG.Sprint4.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Зубкова Мария Геннадьевна | ИСПб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 2 на 5 элементов, заполненный          *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9.                          *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mtrx = new int[2, 5] { { 7, 4, 3, 2, 1 },
                                         { 5, 9, 8, 7, 4 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetLength(1);

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Сумма нечетных элементов массива равна: " + res);

            Console.ReadKey();
        }
    }
}