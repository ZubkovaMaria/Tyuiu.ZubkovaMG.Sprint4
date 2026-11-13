using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZubkovaMG.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, item => item.Length > 4);
            return result.Length;
        }
    }
}