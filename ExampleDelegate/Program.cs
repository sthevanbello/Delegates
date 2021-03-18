using ExampleDelegate.Services;
using System;

namespace ExampleDelegate
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // BinaryNumericOperation op = CalculationService.Sum;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            BinaryNumericOperation op = CalculationService.ShowSum;

            op += CalculationService.ShowMax;

            //double result = op(a, b);
            //double result = op.Invoke(a, b);
            
            op.Invoke(a, b);
            

            
            Console.ReadKey();
        }
    }
}
