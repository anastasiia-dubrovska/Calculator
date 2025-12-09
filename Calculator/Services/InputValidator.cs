using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    class InputValidator
    {
        public string LastError { get; private set; }

        public bool TryParseNumber(string input, out double number)
        {
            if (!double.TryParse(input, out number))
            {
                LastError = "Введено нечислове значення.";
                return false;
            }
            return true;
        }

        public bool ValidateOperation(string op)
        {
            if (op == "+" || op == "-" || op == "*" || op == "/")
                return true;

            LastError = "Операція має бути +, -, * або /.";
            return false;

        }
    }
}
