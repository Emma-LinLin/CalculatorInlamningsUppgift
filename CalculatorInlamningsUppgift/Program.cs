using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorInlamningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";

            string firstOperator;
            string secondOperator;

            double firstTerm;
            double secondTerm;
            double thirdTerm;
            double result = 0;

            List<double> totalSum = new List<double>();

            string userChoice;

            while (true)
            {
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

                if (firstOperator == "+")
                {
                    switch (secondOperator)
                    {
                        case "+":
                            result = firstTerm + secondTerm + thirdTerm;
                            Console.WriteLine($"{firstTerm} + {secondTerm} + {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "-":
                            result = firstTerm + secondTerm - thirdTerm;
                            Console.WriteLine($"{firstTerm} + {secondTerm} - {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "*":
                            result = firstTerm + (secondTerm * thirdTerm);
                            Console.WriteLine($"{firstTerm} + {secondTerm} * {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "/":
                            result = firstTerm + (secondTerm / thirdTerm);
                            Console.WriteLine($"{firstTerm} + {secondTerm} / {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                    }
                }
                else if (firstOperator == "-")
                {
                    switch (secondOperator)
                    {
                        case "+":
                            result = firstTerm - secondTerm + thirdTerm;
                            Console.WriteLine($"{firstTerm} - {secondTerm} + {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "-":
                            result = firstTerm - secondTerm - thirdTerm;
                            Console.WriteLine($"{firstTerm} - {secondTerm} - {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "*":
                            result = firstTerm - (secondTerm * thirdTerm);
                            Console.WriteLine($"{firstTerm} - {secondTerm} * {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "/":
                            result = firstTerm - (secondTerm / thirdTerm);
                            Console.WriteLine($"{firstTerm} - {secondTerm} / {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                    }
                }
                else if (firstOperator == "*")
                {
                    switch (secondOperator)
                    {
                        case "+":
                            result = (firstTerm * secondTerm) + thirdTerm;
                            Console.WriteLine($"{firstTerm} * {secondTerm} + {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "-":
                            result = (firstTerm * secondTerm) - thirdTerm;
                            Console.WriteLine($"{firstTerm} * {secondTerm} - {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "*":
                            result = (firstTerm * secondTerm) * thirdTerm;
                            Console.WriteLine($"{firstTerm} * {secondTerm} * {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "/":
                            result = (firstTerm * secondTerm) / thirdTerm;
                            Console.WriteLine($"{firstTerm} * {secondTerm} / {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                    }
                }
                else if (firstOperator == "/")
                {
                    switch (secondOperator)
                    {
                        case "+":
                            result = (firstTerm / secondTerm) + thirdTerm;
                            Console.WriteLine($"{firstTerm} / {secondTerm} + {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "-":
                            result = (firstTerm / secondTerm) - thirdTerm;
                            Console.WriteLine($"{firstTerm} / {secondTerm} - {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "*":
                            result = firstTerm / (secondTerm * thirdTerm);
                            Console.WriteLine($"{firstTerm} / {secondTerm} * {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                        case "/":
                            result = firstTerm + (secondTerm / thirdTerm);
                            Console.WriteLine($"{firstTerm} / {secondTerm} / {thirdTerm} = {result}");
                            totalSum.Add(result);
                            break;
                    }
                }

                if (result == 100)
                {
                    Console.WriteLine("Congratulations! You now have a hundered, clap clap!");
                }
                else if (result < 100)
                {
                    Console.WriteLine("Your result was less than a hundered");
                }
                else if (result > 100)
                {
                    Console.WriteLine("Your result was more than a hundered");
                }

                Console.WriteLine("Continue? Press \"X\" to quit");
                userChoice = Console.ReadLine().ToLower();

                if (userChoice == "x")
                {
                    double sum = totalSum.Sum();
                    Console.WriteLine($"The total sum of all rounds adds up to {sum}, thanks for playing!");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
