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
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("=== КАЛЬКУЛЯТОР ===");
                Console.WriteLine("Інструкція:");
                Console.WriteLine("1. Введіть перше число");
                Console.WriteLine("2. Введіть операцію (+, -, *, /)");
                Console.WriteLine("3. Введіть друге число");
                Console.WriteLine("4. Отримаєте результат\n");
                Console.WriteLine("Для виходу введіть 'exit'\n");

                var calculator = new CalculatorC();
                var validator = new InputValidator();

                while (true)
                {
                    Console.Write("Перше число: ");
                    string inputA = Console.ReadLine();
                    if (inputA.ToLower() == "exit") break;

                    if (!validator.TryParseNumber(inputA, out double a))
                    {
                        Console.WriteLine($"Помилка: {validator.LastError}\n");
                        continue;
                    }

                    Console.Write("Операція (+, -, *, /): ");
                    string op = Console.ReadLine();

                    if (!validator.ValidateOperation(op))
                    {
                        Console.WriteLine($"Помилка: {validator.LastError}\n");
                        continue;
                    }

                    Console.Write("Друге число: ");
                    string inputB = Console.ReadLine();

                    if (!validator.TryParseNumber(inputB, out double b))
                    {
                        Console.WriteLine($"Помилка: {validator.LastError}\n");
                        continue;
                    }

                    var result = calculator.Calculate(a, b, op);

                    if (!result.Success)
                    {
                        Console.WriteLine($"Помилка: {result.ErrorMessage}\n");
                    }
                    else
                    {
                        Console.WriteLine($"Результат: {result.Value}\n");
                    }
                }

                Console.WriteLine("Програму завершено.");
            }
        }
    }
