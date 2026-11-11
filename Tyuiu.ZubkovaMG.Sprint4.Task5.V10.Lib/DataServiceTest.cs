using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZubkovaMG.Sprint4.Task5.V10.Lib
{
    public class DataService : ISprint4Task5V10
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}