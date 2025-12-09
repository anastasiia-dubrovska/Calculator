using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Models;

namespace Calculator.Services
{
    interface ICalculator
    {
        OperationResult Calculate(double a, double b, string operators);

    }
}
