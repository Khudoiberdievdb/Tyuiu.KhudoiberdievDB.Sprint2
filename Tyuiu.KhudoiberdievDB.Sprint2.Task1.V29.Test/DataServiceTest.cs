using Tyuiu.KhudoiberdievDB.Sprint2.Task1.V29.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657; 
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, true, true };
            CollectionAssert.AreEqual(res, wait);

        }
    }
}