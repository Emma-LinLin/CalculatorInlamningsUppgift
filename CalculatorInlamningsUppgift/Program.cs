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

            string firstOperator, secondOperator;

            double result = 0;

            List<double> totalSum = new List<double>();

            string userChoice;

            while (true)
            {
                bool userInput = false;

                Console.Write("Enter first operator: ");
                firstOperator = Console.ReadLine();

                Console.Write("Enter second operator: ");
                secondOperator = Console.ReadLine();

                Console.Write("Enter first term: ");
                double firstTerm = 0;

                while (!userInput)
                {
                    userInput = double.TryParse(Console.ReadLine(), out firstTerm);

                    if (!userInput)
                    {
                        Console.WriteLine("Try again! Only numbers please");
                    }
                }

                userInput = false;

                Console.Write("Enter second term: ");
                double secondTerm = 0;

                while (!userInput)
                {
                    userInput = double.TryParse(Console.ReadLine(), out secondTerm);

                    if (!userInput)
                    {
                        Console.WriteLine("Try again! Only numbers please");
                    }
                }

                userInput = false;

                Console.Write("Enter third term: ");
                double thirdTerm = 0;

                while (!userInput)
                {
                    userInput = double.TryParse(Console.ReadLine(), out thirdTerm);

                    if (!userInput)
                    {
                        Console.WriteLine("Try again! Only numbers please");
                    }
                }

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
