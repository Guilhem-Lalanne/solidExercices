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

            char[] operators = {'+', '*', '-'};
            foreach (var op in operators)
            {
                if (!operation.Contains(op)) continue;
                switch (op)
                {
                    case '+':
                        substrings = operation.Split(op);
                        result = Convert.ToDouble(substrings[0]);
                        
                        for (int i = 1; i < substrings.Length; i++)
                        {
                            String substring = substrings[i];
                            Double number = Convert.ToDouble(substring);
                            result = result + number;
                        }
                        break;

                    case '*':
                        substrings = operation.Split(op);
                        result = Convert.ToDouble(substrings[0]);
                        
                        for (int i = 1; i < substrings.Length; i++)
                        {
                            String substring = substrings[i];
                            Double number = Convert.ToDouble(substring);
                            result = result * number;
                        }
                        break;

                    case '-':
                        substrings = operation.Split(op);
                        result = Convert.ToDouble(substrings[0]);

                        for (int i = 1; i < substrings.Length; i++)
                        {
                            String substring = substrings[i];
                            Double number = Convert.ToDouble(substring);
                            result = result - number;
                        }
                        break;
                }
            }

            return result;
        }
    }
}