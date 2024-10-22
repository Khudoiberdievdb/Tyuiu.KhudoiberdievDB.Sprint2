using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) | (c == d);
            res[1] = (b + 3 == c) & (b < a);
            res[2] = (a - 100 < b) || (b != a);
            res[3] = (b >= a) && (c == a);
            res[4] = !res[3];
            res[5] = (a - 3 == b) ^ (c < a);
            return res;
        }
    }
}
