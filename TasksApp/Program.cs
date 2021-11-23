/*A1.5. С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?*/

using System;

namespace TasksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double day = 234;
            double week = 7;
            int countWeek = Convert.ToInt32(day / week);
            Console.WriteLine(countWeek);

        }
    }
}
