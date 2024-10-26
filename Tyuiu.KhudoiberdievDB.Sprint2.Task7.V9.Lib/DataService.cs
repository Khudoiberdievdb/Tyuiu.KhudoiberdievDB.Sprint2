using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
       

        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((x > 0) && (x <= 1)) && ((y > 0) && (y <= 0.5)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
