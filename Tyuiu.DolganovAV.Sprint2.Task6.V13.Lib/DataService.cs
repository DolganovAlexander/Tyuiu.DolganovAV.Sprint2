using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DolganovAV.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int MonthDays = m switch
            {
                1 or 3 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 29
            };

            int next_g = g;
            int next_m = m;
            int next_n = n;

            if (n < MonthDays)
            {
                next_n = n + 1;
            }
            else
            {
                next_n = 1;
                next_m = (m % 12) + 1;
                if (next_m == 1)
                {
                    next_g = g + 1;
                }
            }
            return $"{next_n}.{next_m}.{next_g}";
        }
    }
}
