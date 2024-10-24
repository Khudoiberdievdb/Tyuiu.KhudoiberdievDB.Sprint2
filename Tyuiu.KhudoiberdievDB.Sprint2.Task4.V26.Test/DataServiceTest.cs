using Tyuiu.KhudoiberdievDB.Sprint2.Task4.V26.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            double wait = 144;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds =new DataService();
            double x = 4;
            double y = 2;
            var res = ds.Calculate(x, y);
            double wait = 15.5;
            Assert.AreEqual(wait, res);
        }
    }
}