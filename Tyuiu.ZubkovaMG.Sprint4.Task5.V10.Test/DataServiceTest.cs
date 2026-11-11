using Tyuiu.ZubkovaMG.Sprint4.Task5.V10.Lib;
namespace Tyuiu.ZubkovaMG.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5] { { -4, -3, -2, -1, 0 },
                                         { 1, 2, 3, 4, 5 },
                                         { -4, -3, -2, -1, 0 },
                                         { 1, 2, 3, 4, 5 },
                                         { 1, 1, 1, 1, 1 } };
            int res = ds.Calculate(mtrx);
            int wait = 35;
            Assert.AreEqual(wait, res);
        }
    }
}