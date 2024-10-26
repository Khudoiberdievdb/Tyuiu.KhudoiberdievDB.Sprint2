using Tyuiu.KhudoiberdievDB.Sprint2.Task7.V9.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInDhadeArea()
        {
            DataService ds = new DataService();
            double x= 0.5;
            double y= 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }

    }
}