using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    class OperationResult
    {
        public bool Success { get; private set; }
        public double Value { get; private set; }
        public string ErrorMessage { get; private set; }

        private OperationResult() { }

        public static OperationResult SuccessResult(double value)
        {
            return new OperationResult
            {
                Success = true,
                Value = value
            };
        }

        public static OperationResult Error(string message)
        {
            return new OperationResult
            {
                Success = false,
                ErrorMessage = message
            };
        }
    }
}
