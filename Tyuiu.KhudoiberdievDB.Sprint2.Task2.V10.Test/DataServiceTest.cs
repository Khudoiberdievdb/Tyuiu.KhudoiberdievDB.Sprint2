using Tyuiu.KhudoiberdievDB.Sprint2.Task2.V10.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 8;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);


        }
    }
}