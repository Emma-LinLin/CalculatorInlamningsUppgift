using System;

namespace CalculatorInlamningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstOperator;
            string secondOperator;
            double firstTerm;
            double secondTerm;
            double thirdTerm;

            Console.Write("Enter first operator: ");
            firstOperator = Console.ReadLine();

            Console.Write("Enter second operator: ");
            secondOperator = Console.ReadLine();

            Console.Write("Enter first term: ");
            firstTerm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second term: ");
            secondTerm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third term: ");
            thirdTerm = Convert.ToDouble(Console.ReadLine());
        }
    }
}
