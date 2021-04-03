using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 5, 9, 87, 56 };
          SortArray(numbers);
           AddElementAtStart(numbers, 12);
            AddElementAtEnd(numbers,35);
            AddElementAtAnyPosition(numbers, 33, 4);


        }

        private static void SortArray(int[] numbers)
        {
            int temp =0;
            for(int i =0; i < numbers.Length - 1; i++)
            {
                for(int j= i+1; j < numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array");
            foreach (int number in numbers)
            {
 
                Console.Write(number + " ");
            }
        }
        private static void AddElementAtEnd(int[] numbers, int newNumber)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            int index = numbers.Length;
            for(int i=0; i<numbers.Length+1; i++)
            {
                 if(i == index)
                {
                    newNumbers[i] = newNumber;
                }
                else
                {
                    newNumbers[i] = numbers[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Add element at the end of array");
            for (int i = 0; i < numbers.Length + 1; i++)
            {
                Console.Write(newNumbers[i] + " ");
            }
        }

        private static void AddElementAtStart(int[] numbers, int newNumber)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            int index = 0;
            for (int i = 0; i < numbers.Length + 1; i++)
            {
                if (i == index)
                {
                    newNumbers[i] = newNumber;
                }
                else
                {
                    newNumbers[i] = numbers[i-1];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Add element at the beginning of array");
            for (int i = 0; i < numbers.Length + 1; i++)
            {
                Console.Write(newNumbers[i] + " ");
            }
        }

        private static void AddElementAtAnyPosition(int[] numbers, int newNumber,int position)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length + 1; i++)
            {
                if (i == position)
                {
                    newNumbers[i] = newNumber;
                }
                else if(i < position)
                {
                    newNumbers[i] = numbers[i];
                }
                else
                {
                    newNumbers[i] = numbers[i - 1];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Add element at the the position you want in the array");
            for (int i = 0; i < numbers.Length + 1; i++)
            {
                Console.Write(newNumbers[i] + " ");
            }
        }
    }
}
