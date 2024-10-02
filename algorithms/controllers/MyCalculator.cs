using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class MyCalculator
{
    public double CalculatorFunc(double a, double b,string operation)
    {
        var validOperations = new List<string> { "+", "-", "/", "*" };
        if (!validOperations.Contains(operation))
        {
            throw new ArgumentException($"Invalid operation: {operation}");
        }
        if (operation == "+")
        {
            return a + b;
        }
        else if (operation == "-")
        {
            return a - b;
        }
        else if (operation == "/") {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");

            }
            return a / b;


        }
        return a * b;
    }
}

