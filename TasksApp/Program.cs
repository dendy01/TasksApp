/* Вычислить дату следующего дня.
 * Например: введите сегодняшнюю дату (число, месяц, год): 08 06 2012. 
 * Завтра: 09 06 2012;*/

using System;

namespace TasksApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] DayInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Enter today's data: ");

            Console.Write("Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int newDay = day + 1;

            Console.Write("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            int newMonth = month;

            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int newYear = year + 1;

            if (day >= DayInMonth[0] & month == 1)
             {
                 if (day > DayInMonth[0])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[1] & year % 4 != 0 & month == 2)
             {
                 if (day > DayInMonth[1])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }   
             }
             else if (day >= DayInMonth[2] & month == 3)
             {
                 if (day > DayInMonth[2])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[3] & month == 4)
             {
                 if (day > DayInMonth[3])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[4] & month == 5)
             {
                 if (day > DayInMonth[4])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[5] & month == 6)
             {
                 if (day > DayInMonth[5])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[6] & month == 7)
             {
                 if (day > DayInMonth[6])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[7] & month == 8)
             {
                 if (day > DayInMonth[7])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[8] & month == 9)
             {
                 if (day > DayInMonth[8])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[9] & month == 10)
             {
                 if (day > DayInMonth[9])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[10] & month == 11)
             {
                 if (day > DayInMonth[10])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if (day >= DayInMonth[11] & month == 12)
             {
                 if (day > DayInMonth[11])
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }
             }
             else if(day >= 29 & year % 4 == 0 & month == 2)
             {
                 if (day > 29)
                 {
                     Console.WriteLine("Incorrect date");
                 }
                 else
                 {
                     newDay = 1;
                     newMonth = month + 1;
                     Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
                 }        
             } 
             else
             {
                 Console.WriteLine("New date: " + newDay + "." + newMonth + "." + year);
             }
        }
    }
}
