using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolganovAV.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            res = true;
            if (x < 3 || x > 13 || y < 3 || y > 14) return res = false;

            if (x == 3) return y <= 4 || y == 7 || y == 11;
            if (x == 4) return y <= 4 || (y >= 7 && y <= 13);
            if (x == 5) return y <= 7 || y == 14;
            if (x == 6) return (y >= 5 && y <= 7) || y == 14;
            if (x == 7) return y >= 5 && y <= 7;
            if (x == 8) return y >= 5 && y <= 12;
            if (x == 9) return y <= 12;
            if (x == 10) return y >= 7 && y <= 12;
            if (x == 11) return (y >= 7 && y <= 8) || y == 11;
            if (x == 12) return (y >= 3 && y <= 8) || y == 11;
            if (x == 13) return y >= 6 && y <= 8;
            return res = false;
        }
    }
}
