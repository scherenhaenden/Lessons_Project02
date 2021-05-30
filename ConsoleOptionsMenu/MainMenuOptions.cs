using System;
using Learning_Project02.Math;

namespace Learning_Project02.ConsoleOptionsMenu
{
    public class MainMenuOptions
    {
        public void PrintFirstMenu()
        {
            var inputMain = "main";

            while (!string.Equals(inputMain, "0", StringComparison.Ordinal))
            {
                var basicInstructions = new BasicInstructions();
                Console.WriteLine("Following operations are available");
                Console.WriteLine("(S)um, (R)est, (M)ultiply");
                Console.WriteLine("(D)ivide, S(q)uare, (C)ube");
                Console.WriteLine("Sq(u)reroot, Rec(i)procal");
                Console.WriteLine("(0) for Exist");
                inputMain = Console.ReadLine();

                if (inputMain != null && inputMain.ToLower() == "s")
                {
                    var firstNumber = GetNumberValue();
                    var secondNumber = GetNumberValue();

                    var result =basicInstructions.SumTwoNumbers(firstNumber, secondNumber);
                    Console.WriteLine($"result: {result}");
                }
                
                else if (inputMain != null && inputMain.ToLower() == "r")
                {
                    var firstNumber = GetNumberValue();
                    var secondNumber = GetNumberValue();

                    var result =basicInstructions.RestSecondNumberFromTheFirst(firstNumber, secondNumber);
                    Console.WriteLine($"result: {result}");
                }
                
                else if (inputMain != null && inputMain.ToLower() == "m")
                {
                    var firstNumber = GetNumberValue();
                    var secondNumber = GetNumberValue();

                    var result =basicInstructions.MultiplyTwoNumbers(firstNumber, secondNumber);
                    Console.WriteLine($"result: {result}");
                }
                
                else if (inputMain != null && inputMain.ToLower() == "d")
                {
                    var firstNumber = GetNumberValue();
                    var secondNumber = GetNumberValue();

                    var result =basicInstructions.DivideTwoNumbers(firstNumber, secondNumber);
                    Console.WriteLine($"result: {result}");
                }
                
                else if (inputMain != null && inputMain.ToLower() == "q")
                {
                    var firstNumber = GetNumberValue();
                    var result =basicInstructions.SquareFunction(firstNumber);
                    Console.WriteLine($"result: {result}");
                }
                
                else if (inputMain != null && inputMain.ToLower() == "c")
                {
                    var firstNumber = GetNumberValue();
                    var result =basicInstructions.CubeFunction(firstNumber);
                    Console.WriteLine($"result: {result}");
                }
                
                else if (inputMain != null && inputMain.ToLower() == "u")
                {
                    var firstNumber = GetNumberValue();
                    var result =basicInstructions.SquareRootFunction(firstNumber);
                    Console.WriteLine($"result: {result}");
                }
                
                else if (inputMain != null && inputMain.ToLower() == "i")
                {
                    var firstNumber = GetNumberValue();
                    var result =basicInstructions.ReciprocalFunction(firstNumber);
                    Console.WriteLine($"result: {result}");
                }

                else if (inputMain != null && inputMain.ToLower() == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please learn how to read");
                    Console.WriteLine("You introduced a wrong option");
                }
            }
        }

        public int GetNumberValue()
        {
            bool isNumber = false;
            int value = 0;
            while (!isNumber)
            {
                Console.WriteLine("Please introduce a number");
                //var inputMain = Console.ReadLine();
                
                isNumber = TryGetNumberFromTheConsole(out value);
                
                if (!isNumber)
                {
                    Console.WriteLine("Your input was not valid");
                }
                else
                {
                    return value;
                }
            }
            return value;
        }

        public bool TryGetNumberFromTheConsole(out int inconmmingValue)
        {
            var inputMain = Console.ReadLine();

            if (inputMain != null)
            {
                return int.TryParse(inputMain, out inconmmingValue);

            }

            inconmmingValue = 0;
            return false;
        }
    }
}