using Tyuiu.ZubkovaMG.Sprint4.Task4.V29.Lib;
namespace Tyuiu.ZubkovaMG.Sprint4.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] inArray = new int[2, 5] { { 7, 4, 3, 2, 1 },
                                             { 5, 9, 8, 7, 4 } };

            int res = ds.Calculate(inArray);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}