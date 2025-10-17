using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RadchenkoAV.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string dat;
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1: g--; return "31.12." + g;
                        default:
                            m--;
                            switch (m)
                            {
                                case 2: return "28.0" + m + "." + g;
                                case 10:
                                    return "31." + m + "." + g;
                                case 8:
                                case 7:
                                case 5:
                                case 3:
                                case 1:
                                    return "31.0" + m + "." + g;
                                case 11: return "30." + m + "." + g;
                                case 9:
                                case 6:
                                case 4:
                                    return "30.0" + m + "." + g;
                                default:
                                    throw new ArgumentException("Месяц должен быть от 1 до 12");
                            }
                    }
                default:
                    n--;
                    if (n < 10 && m < 10) { return "0" + n + ".0" + m + "." + g; }
                    else if (n > 10 && m < 10) { return n + ".0" + m + "." + g; }
                    else if (n < 10 && m > 10) { return "0" + n + "." + m + "." + g; }
                    else { return n + "." + m + "." + g; }
            }
        }
    }
}
