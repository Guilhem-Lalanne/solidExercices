using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {
            Double result = 0;
            String[] substrings;

            char[] operators = {'+', '*'};
            foreach (var op in operators)
            {
                if (operation.Contains(op))
                {
                    switch (op)
                    {
                        case '+':
                            substrings = operation.Split(op);
                            result = 0;
                            foreach (var substring in substrings)
                            {
                                Double number = Convert.ToDouble(substring);
                                result = result + number;
                            }
                            break;

                        case '*':
                            substrings = operation.Split(op);
                            result = 1;
                            foreach (var substring in substrings)
                            {
                                Double number = Convert.ToDouble(substring);
                                result = result * number;
                            }
                            break;
                    }
                }
            }

            return result;
        }
    }
}