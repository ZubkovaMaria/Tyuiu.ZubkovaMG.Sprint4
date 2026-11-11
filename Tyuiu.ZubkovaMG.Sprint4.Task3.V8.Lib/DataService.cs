using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZubkovaMG.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int min = array[0, 3];

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 3] < min)
                {
                    min = array[i, 3];
                }
            }
            return min;
        }
    }
}