using Tyuiu.ZubkovaMG.Sprint4.Task7.V13.Lib;
namespace Tyuiu.ZubkovaMG.Sprint4.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];

            string str = "159357246";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Зубкова Мария Георгиевна | ИСПб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"159357246\". Преобразуйте ее в        *");
            Console.WriteLine("* матрицу 3 на 3 и подсчитайте количество четных чисел.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Количество четных элементов = " + res);
            Console.ReadKey();
        }
    }
}