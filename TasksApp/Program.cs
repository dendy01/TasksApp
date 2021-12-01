/*Вычислить оптимальную для пользователя массу. Сравнить ее
  с реальной массой и вывести в консоль рекомендацию поправиться
  или похудеть на определенное количество килограммов. Расчет оптимальной массы производится по формуле: рост(см)–100.Например:
  Ваш рост(см) 175
  Ваш вес(кг): 95
  Вам необходимо похудеть на 15 кг*/

using System;

namespace OptimalMass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To colculate the optimal weight enter your height");
            Console.Write("Your height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double optimalWeight = height - 100;
            Console.WriteLine("Optimal weight: " + optimalWeight);

            if (optimalWeight == weight)
            {
                Console.WriteLine("For this height, your weight is optimal");
            }
            else if (weight > optimalWeight)
            {
                double heavyWeight = weight - optimalWeight;
                Console.WriteLine("You are recommended to lose weight by: " + heavyWeight + " kg");
            }
            else if (weight < optimalWeight)
            {
                double smallWeight = optimalWeight - weight;
                Console.WriteLine("It is recommended to gain weight on: " + smallWeight + " kg");
            }
        }
    }
}


