using System;
using System.IO;

namespace Homework3
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write(" please enter your username:");
            string username = Console.ReadLine();

            Console.Write(" please enter your password:");
            string password = Console.ReadLine();
            string filePath = @"Users.txt";

            ValidateFile(filePath);
            LoginAndRegistration(filePath, username, password);

        }



        static void LoginAndRegistration(string path, string username, string password)
        {
            var fileContents = ReadFile(path);
         

            if (fileContents.Contains(username) && fileContents.Contains(password))
            {
                Console.WriteLine("hello!");
            }
            else
            {
                WriteInTheFile(path, username, password);

                fileContents = ReadFile(path);
                var contentsArray = fileContents.Split(" ");
              
                for(int i=0; i <contentsArray.Length; i++)
                {
                    for(int j=i+1; j<contentsArray.Length; j++)
                    {
                        if(contentsArray[i] == contentsArray[j])
                        {
                            WriteInTheFile(path, username, password);
                        }
                    }
                }

             Console.WriteLine("Register!");
                
            }


        }
        static void ValidateFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Environment.Exit(1);
                }
            }
            catch (DuplicateUserCredentialsException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static string ReadFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            var contents = reader.ReadToEnd();
            reader.Dispose();
            return contents;
        }

        static void WriteInTheFile(string path, string username, string password)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.Write(username + " " +password);

            writer.Dispose();
        }
    }
}
