using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 5, 9, 87, 56 };
            SortArray(numbers);
            int[] addElementInArray = AddElementAtAnyPosition(numbers, 32, numbers.Length);
            PrintArray(addElementInArray);
            int[]removeElementInArray = RemoveElementAtPositon(numbers, 4);
            PrintArray(removeElementInArray);
            LoginInfo("KIN", "21lome");

        }
        // Print  out array element
       private static void PrintArray(int[] array)
        {
            foreach(int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        // sorting an array
       private static int[] SortArray(int[] numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                ;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
           
        }
       
        // Add element at any position
        private static int[] AddElementAtAnyPosition(int[] numbers, int newNumber, int position)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length + 1; i++)
            {
                if (i == position)
                {
                    newNumbers[i] = newNumber;
                }
                else if (i < position)
                {
                    newNumbers[i] = numbers[i];
                }
                else
                {
                    newNumbers[i] = numbers[i - 1];
                }
            }
            return newNumbers;
        }

        // Add element at the beginning

        private static int[] AddElementAtStart(int[] numbers, int newNumber)
        {
            int[] addInTheStart = AddElementAtAnyPosition(numbers, newNumber, 0);

               return addInTheStart;
        }

        // Add element at the end
        private static int[] AddElementAtEnd(int[] numbers, int newNumber)
        {
            int[] addInTheEnd = AddElementAtAnyPosition(numbers, newNumber, numbers.Length-1);

            return addInTheEnd;
        }

        // remove element from array at any position
        private static int[] RemoveElementAtPositon(int[] numbers, int index)
        {
            int[] newArray = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (i < index)
                {
                    newArray[i] = numbers[i];
                }
                if (i >= index)
                {
                    newArray[i] = numbers[i + 1];
                }

            }
            return newArray;
        }

        // Remove element at the Start
        private static int[] RemoveElementAtStart(int[] numbers)
        {
            int[] removeAtTheStart = RemoveElementAtPositon(numbers,0);

            return removeAtTheStart;
        }

        // Remove element at the End
        private static int[] RemoveElementAtEnd(int[] numbers)
        {
            int[] removeAtTheEnd = RemoveElementAtPositon(numbers, numbers.Length -1);

            return removeAtTheEnd;
        }
        // Chech login info
        private static void LoginInfo(string name, string password)
        {
            string myName = "Kin";
            string pwd = "21Lome";
            if (myName.Equals(name, StringComparison.OrdinalIgnoreCase) && pwd.Equals(password, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Loggin in!");
            }
        }
    }
}
