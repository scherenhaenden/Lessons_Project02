using System;
using Learning_Project02.Math;

namespace Learning_Project02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please, insert the first number");
            var value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, insert the second number");
            var value2 = Convert.ToInt32(Console.ReadLine());

            BasicInstructions basicInstructions = new BasicInstructions();
            var result = basicInstructions.SumTwoNumbers(value1, value2);
            Console.WriteLine($"The summatory of the first value " + value1 + " and the second value "+ value2+ " is:");
            Console.WriteLine(result);
        }
    }
}