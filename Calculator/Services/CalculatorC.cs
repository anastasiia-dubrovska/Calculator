using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Models;

namespace Calculator.Services
{
    class CalculatorC: ICalculator
    {
        public OperationResult Calculate(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return OperationResult.SuccessResult(a + b);

                case "-":
                    return OperationResult.SuccessResult(a - b);

                case "*":
                    return OperationResult.SuccessResult(a * b);

                case "/":
                    if (b == 0)
                        return OperationResult.Error("Diviting by zero.");
                    return OperationResult.SuccessResult(a / b);

                default:
                    return OperationResult.Error("Unknown operation.");
            }
        }
    }
}
