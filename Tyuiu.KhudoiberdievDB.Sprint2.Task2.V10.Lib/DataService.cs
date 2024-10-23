using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KhudoiberdievDB.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7) || (x >= 6) && (x <= 12) && (y >= 5) && (y <= 7) || (x >= 9) && (x <= 12) && (y >= 3) && (y <= 4) || (x >= 6) && (x <= 9) && (y >= 8) && (y <= 9) || (x >= 8) && (x <= 9) && (y >= 10) && (y <= 12) || (x >= 10) && (x <= 13) && (y == 8) || (x == 13) && (y >= 6) && (y <= 7) || (x == 4) && (y >= 8) && (y <= 14) || (x == 3) && (y == 11) || (x == 5) && (y == 11) || (x >= 2) && (x <= 3) && (y == 14) || (x >= 5) && (x <= 6) && (y == 14)) 
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
