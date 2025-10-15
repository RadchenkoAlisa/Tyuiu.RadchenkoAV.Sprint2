using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RadchenkoAV.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = y + 46 == x;
            res[1] = x != y;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = x <= y;
            res[5] = y >= x;
            return res;
        }
    }
}
