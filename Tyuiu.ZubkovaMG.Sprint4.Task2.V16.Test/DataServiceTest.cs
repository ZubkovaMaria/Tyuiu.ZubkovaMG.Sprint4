using Tyuiu.ZubkovaMG.Sprint4.Task2.V16.Lib;
namespace Tyuiu.ZubkovaMG.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3 };
            int res = ds.Calculate(numsArray);
            int wait = 27;
            Assert.AreEqual(wait, res);
        }
    }
}