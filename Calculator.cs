using System;
using System.Collections.Generic;

namespace MyCalculator
{
    public class Calculator
    {
        private readonly Dictionary<string, Func<double, double, double>> operations = new()
            {
                { "+", (x, y) => x + y },
                { "-", (x, y) => x - y },
                { "*", (x, y) => x * y },
                { "/", (x, y) => x / y },
            };
        public void DefineOperation(string op, Func<double, double, double> body)
        {
            if (operations.ContainsKey(op))
                throw new ArgumentException($"Operation {op} is invalid", nameof(op));
            operations.Add(op, body);
        }
        public double PerformOperation(string op, double x, double y)
        {
            if (!operations.ContainsKey(op))
                throw new ArgumentException($"Operation {op} is invalid", nameof(op));
            return operations[op](x, y);
        }
    }
}