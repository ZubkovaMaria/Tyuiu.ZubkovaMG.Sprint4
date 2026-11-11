using Tyuiu.ZubkovaMG.Sprint4.Task1.V12.Lib;
namespace Tyuiu.ZubkovaMG.Sprint4.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Зубкова Мария Геннадьевна | ИСПб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный          *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9.                          *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 13;
            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Введите значение {i + 1}-го элемента:");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Произведение нечетных элементов массива равно: " + res);

            Console.ReadKey();
        }
    }
}