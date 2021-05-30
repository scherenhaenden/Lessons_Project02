using System.Diagnostics.CodeAnalysis;

namespace Learning_Project02.Math
{
    public class BasicInstructions
    {
        public int SumTwoNumbers(int a, int b)
        {
            return a + b;

        }
        
        public int RestSecondNumberFromTheFirst(int a, int b)
        {
            return a - b;

        }
        
        public int MultiplyTwoNumbers(int a, int b)
        {
            return a * b;

        }
        
        public float DivideTwoNumbers(int a, int b)
        {
            // TODO: take a look onto this
            return (float)a / b;
        }
        
        public int SquareFunction(int a)
        {
            return a * a;
        }
        
        public int CubeFunction(int a)
        {
            return a * a * a;
        }
        
        public double SquareRootFunction(int a)
        {
            return System.Math.Sqrt(a);
        }
        
        public double ReciprocalFunction(int a)
        {
            return ((float)1 / a);
        }
        
        
    }
}