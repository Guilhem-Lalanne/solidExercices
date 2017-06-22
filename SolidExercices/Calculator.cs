using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            // split('+')
            Char op = '+';
            String[] substrings = operation.Split(op);
            Double sum = 0;
            foreach (var substring in substrings)
            {
                Double number = Convert.ToDouble(substring);
                sum = sum + number;
            }

            return sum;
        }

    }
}