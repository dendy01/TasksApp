/*A1 .7.Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?*/
using System;

namespace TasksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 543;
            double height = 130;

            double sideSquare = 130;
           
            int countSquare = Convert.ToInt32(width / sideSquare) * Convert.ToInt32(height / sideSquare);


            Console.WriteLine("Count square = " + countSquare);

        }
    }
}
