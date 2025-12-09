using Calculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("1. Enter first number");
                Console.WriteLine("2. Enter operation (+, -, *, /)");
                Console.WriteLine("3. Enter second number");
                Console.WriteLine("4. Result: \n");
                Console.WriteLine("To enter print 'exit'\n");

                var calculator = new CalculatorC();
                var validator = new InputValidator();

                while (true)
                {
                    Console.Write("First number: ");
                    string inputA = Console.ReadLine();
                    if (inputA.ToLower() == "exit") break;

                    if (!validator.TryParseNumber(inputA, out double a))
                    {
                        Console.WriteLine($"Error: {validator.LastError}\n");
                        continue;
                    }

                    Console.Write("Operation (+, -, *, /): ");
                    string op = Console.ReadLine();

                    if (!validator.ValidateOperation(op))
                    {
                        Console.WriteLine($"Error: {validator.LastError}\n");
                        continue;
                    }

                    Console.Write("Second number: ");
                    string inputB = Console.ReadLine();

                    if (!validator.TryParseNumber(inputB, out double b))
                    {
                        Console.WriteLine($"Error: {validator.LastError}\n");
                        continue;
                    }

                    var result = calculator.Calculate(a, b, op);

                    if (!result.Success)
                    {
                        Console.WriteLine($"Error: {result.ErrorM}\n");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {result.Value}\n");
                    }
                }
            }
        }
    }
