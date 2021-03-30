using System;

namespace HomeworkAssignement1
{
    class Program
    {

        static void Main(string[] args)

        {
            double bmi = PrintPersonInfo();
            PrintBmi(bmi);
            PrintPersonInfo();

        }

        static double PrintPersonInfo()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Please enter your height in cm: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and is height is {height} cm.");

            double bmi = weight * 10000 / (height * height);
            return bmi;

        }
        static void PrintBmi(double bmi)
        {
            
            Console.WriteLine($"Your body mass index is {bmi:F2}");
        }
      
    }

}


