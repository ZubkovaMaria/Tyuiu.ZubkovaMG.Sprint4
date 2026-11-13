using Tyuiu.ZubkovaMG.Sprint4.Task6.V13.Lib;
namespace Tyuiu.ZubkovaMG.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] cars = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

            int res = ds.Calculate(cars);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}