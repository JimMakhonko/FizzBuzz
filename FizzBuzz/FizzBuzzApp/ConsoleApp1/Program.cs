using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to loop through: ");
            int inputNumber = int.Parse(Console.ReadLine());
            for(int i = 1; i <= inputNumber; i++)
            {
                var output = "";

                if( i % 3 == 0 )
                {
                    output += "Fizz";
                }
                if( i % 5 == 0 )
                {
                    output += "Buzz";
                }
                if(output == "")
                {
                    output = Convert.ToString(i);
                }
                Console.WriteLine(output);
            }

            //Waiting for user to acknowledge the result
            Console.WriteLine("Press Enter to exit...");
            Console.Read();
        }
    }
}
