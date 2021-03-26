using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPersonInfo();
            PrintPersonInfo();

        }

        static void PrintPersonInfo()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your surname: ");
            string surName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            double age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Please enter your height in cm: ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight * 100 / (height * 2);

            Console.WriteLine();
            Console.WriteLine($"{name} {surName} is {age} years old, his weight is {weight} kg and is height is {height} cm.");

            Console.WriteLine($"{name} {surName} body Mass Index is {bmi:F2}");
            Console.ReadLine();
        }
        
    }
}
