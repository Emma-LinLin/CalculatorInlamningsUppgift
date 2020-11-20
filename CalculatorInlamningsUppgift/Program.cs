using System;
using System.Collections.Generic;

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
            double result = 0;

            List<double> totalSum = new List<double>();

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

            if(firstOperator == "+")
            {
                if (secondOperator == "+")
                {
                    result = firstTerm + secondTerm + thirdTerm;
                    Console.WriteLine($"{firstTerm} + {secondTerm} + {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "-")
                {
                    result = firstTerm + secondTerm - thirdTerm;
                    Console.WriteLine($"{firstTerm} + {secondTerm} - {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "*")
                {
                    result = firstTerm + (secondTerm * thirdTerm);
                    Console.WriteLine($"{firstTerm} + {secondTerm} * {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "/")
                {
                    result = firstTerm + (secondTerm / thirdTerm);
                    Console.WriteLine($"{firstTerm} + {secondTerm} / {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
            }
            else if (firstOperator == "-")
            {
                if (secondOperator == "+")
                {
                    result = firstTerm - secondTerm + thirdTerm;
                    Console.WriteLine($"{firstTerm} - {secondTerm} + {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "-")
                {
                    result = firstTerm - secondTerm - thirdTerm;
                    Console.WriteLine($"{firstTerm} - {secondTerm} - {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "*")
                {
                    result = firstTerm - (secondTerm * thirdTerm);
                    Console.WriteLine($"{firstTerm} - {secondTerm} * {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "/")
                {
                    result = firstTerm - (secondTerm / thirdTerm);
                    Console.WriteLine($"{firstTerm} - {secondTerm} / {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
            }
            if (firstOperator == "*")
            {
                if (secondOperator == "+")
                {
                    result = (firstTerm * secondTerm) + thirdTerm;
                    Console.WriteLine($"{firstTerm} * {secondTerm} + {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "-")
                {
                    result = (firstTerm * secondTerm) - thirdTerm;
                    Console.WriteLine($"{firstTerm} * {secondTerm} - {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "*")
                {
                    result = (firstTerm * secondTerm) * thirdTerm;
                    Console.WriteLine($"{firstTerm} * {secondTerm} * {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (secondOperator == "/")
                {
                    result = (firstTerm * secondTerm) / thirdTerm;
                    Console.WriteLine($"{firstTerm} * {secondTerm} / {thirdTerm} = {result}");
                    totalSum.Add(result);
                }
                else if (firstOperator == "/")
                {
                    if (secondOperator == "+")
                    {
                        result = (firstTerm / secondTerm) + thirdTerm;
                        Console.WriteLine($"{firstTerm} / {secondTerm} + {thirdTerm} = {result}");
                        totalSum.Add(result);
                    }
                    else if (secondOperator == "-")
                    {
                        result = (firstTerm / secondTerm) - thirdTerm;
                        Console.WriteLine($"{firstTerm} / {secondTerm} - {thirdTerm} = {result}");
                        totalSum.Add(result);
                    }
                    else if (secondOperator == "*")
                    {
                        result = firstTerm / (secondTerm * thirdTerm);
                        Console.WriteLine($"{firstTerm} / {secondTerm} * {thirdTerm} = {result}");
                        totalSum.Add(result);
                    }
                    else if (secondOperator == "/")
                    {
                        result = firstTerm + (secondTerm / thirdTerm);
                        Console.WriteLine($"{firstTerm} / {secondTerm} / {thirdTerm} = {result}");
                        totalSum.Add(result);
                    }
                }
            }
        }
    }
}
