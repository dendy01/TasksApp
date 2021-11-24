/*A1.6. С начала суток прошло n секунд. Определить:
а) сколько полных часов прошло с начала суток;
б) сколько полных минут прошло с начала очередного часа;
в) сколько полных секунд прошло с начала очередной минуты.*/
using System;

namespace TasksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please specify time  in seconds = ");
            double time = double.Parse(Console.ReadLine());
            Console.WriteLine("Time in seconds = " + time);
            double timeHours = (time / 3600);
            Console.WriteLine("Full hours have passed sinse the beginning of the day  = " + timeHours);
            double timeMinuts = (timeHours * 60);
            Console.WriteLine("Full minuts have passed sinse the beginning of the hours = " + timeMinuts);
            double timeSeconds = (timeMinuts * 60);
            Console.WriteLine("Full seconds have passed the beginning of the minute = " + timeSeconds);
        }
    }
}
