using System;

namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Interpreter
{
    public class Calculator
    {
        public static double Calculate(string expression)
        {
            AritheticExpression endExpre = create_ExpressionTree(expression, 0, expression.Length - 1);
            return endExpre.Interpret();
        }
        static int findSplit(string expression, int start, int end)
        {
            int tag = -1;
            if (expression[start] == '(' && expression[end] == ')')
            {
                ++start;
                --end;
            }
            int isInBraket = 0;
            int moreGrade = 0;
            for (int i = start; i <= end; i++)
            {
                if (expression[i] == '(')
                    ++isInBraket;
                else if (expression[i] == ')')
                    --isInBraket;
                if ((expression[i] == '+' || expression[i] == '-') && isInBraket == 0)
                {
                    moreGrade = 1;
                    tag = i;
                }
                else if ((expression[i] == '*' || expression[i] == '/') && moreGrade == 0 && isInBraket == 0)
                    tag = i;
            }
            return tag;
        }
        static AritheticExpression create_ExpressionTree(string expression, int start, int end)
        {
            AritheticExpression ptree = null;
            if (double.TryParse(expression.Substring(start, end - start + 1), out double num))
            {
                ptree = new NumberExpression(num);
            }
            else
            {
                int tag = findSplit(expression, start, end);
                if (tag < 0)
                {
                    string[] s = expression.Substring(start, end - start + 1).Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    ptree = new NumberExpression(double.Parse(s[0]));
                }
                else
                {
                    if (expression[tag] == '+')
                        ptree = new AdditionExpression(create_ExpressionTree(expression, start, tag - 1), create_ExpressionTree(expression, tag + 1, end));
                    else if (expression[tag] == '-')
                        ptree = new SubtractionExpression(create_ExpressionTree(expression, start, tag - 1), create_ExpressionTree(expression, tag + 1, end));
                    else if (expression[tag] == '*')
                        ptree = new MultiplicationExpression(create_ExpressionTree(expression, start, tag - 1), create_ExpressionTree(expression, tag + 1, end));
                    else if (expression[tag] == '/')
                        ptree = new DivisionExpression(create_ExpressionTree(expression, start, tag - 1), create_ExpressionTree(expression, tag + 1, end));
                }
                if (expression[start] == '(' && expression[end] == ')')
                {
                    ++start;
                    --end;
                }
            }
            return ptree;
        }
    }
}
