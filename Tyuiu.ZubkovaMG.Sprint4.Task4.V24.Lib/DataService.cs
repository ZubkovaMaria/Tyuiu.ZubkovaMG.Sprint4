using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZubkovaMG.Sprint4.Task4.V24.Lib
{
    public class DataService : ISprint4Task4V24
    {
        public int[,] Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }
    }
}