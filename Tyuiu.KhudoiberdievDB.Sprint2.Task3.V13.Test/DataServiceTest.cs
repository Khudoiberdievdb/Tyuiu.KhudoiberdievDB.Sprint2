using Tyuiu.KhudoiberdievDB.Sprint2.Task3.V13.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            int x = 0;
            var res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            int x = -20;
            var res = ds.Calculate(x);
            double wait = -219.95;
            Assert.AreEqual(res, wait);
        }


    }   
    
}