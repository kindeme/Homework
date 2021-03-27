using System;

namespace HomeworkAssignement1
{
    class Program
    {

        static void Main(string[] args)
        {
            PrintPersonInfo();
            PrintBmi();
            PrintPersonInfo();
        }

        static void PrintPersonInfo()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            double weight = InputWeight();
            double height = InputHeight();
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and is height is {height} cm.");
        }

        static void PrintBmi()
        {
            double weight = InputWeight();
            double height = InputHeight();
            double bmi = weight * 10000 / (height * height);
            Console.WriteLine($"Your body mass index is {bmi:F2}");
        }
        static double InputWeight()
        {
            Console.Write("Please enter your weight in kg: ");
            double weight = double.Parse(Console.ReadLine());
            return weight;
        }
        static double InputHeight()
        {
            Console.Write("Please enter your height in cm: ");
            double height = double.Parse(Console.ReadLine());
            return height;
        }

    }

}


