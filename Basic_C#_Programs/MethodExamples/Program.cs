using System;

namespace MethodExamples
{
    class Program
    {
        static void Main()
        {
            MethodCalculation methodCalculation = new MethodCalculation();
            int inputNumber = 0;

            Console.WriteLine("Please enter a number to follow up with addition, substraction and multiplication:");
            inputNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(inputNumber + " + " + inputNumber + " = " + methodCalculation.SumInt(inputNumber));
            Console.WriteLine(inputNumber + " - " + inputNumber + " = " + methodCalculation.SubInt(inputNumber));
            Console.WriteLine(inputNumber + " * " + inputNumber + " = " + methodCalculation.MultInt(inputNumber));

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
