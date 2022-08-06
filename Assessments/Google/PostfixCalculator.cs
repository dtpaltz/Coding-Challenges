namespace Assessments.Google
{
    internal class PostfixCalculator
    {
        /// <summary>
        /// Will throw exception if expr is malformed
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public double SolvePostFix(string expr)
        {
            expr = expr.Trim().Replace("  ", " ");

            var exprElements = expr.Split(' ');

            var stackArgOp = new Stack<string>();

            double arg1, arg2, ans;

            for (int i = 0; i < exprElements.Length; i++)
            {
                string thisCh = exprElements[i];

                if (thisCh.Equals("*"))
                {
                    arg2 = double.Parse(stackArgOp.Pop());
                    arg1 = double.Parse(stackArgOp.Pop());
                    ans = arg1 * arg2;
                    stackArgOp.Push(ans.ToString());
                }
                else if (thisCh.Equals("/"))
                {
                    arg2 = double.Parse(stackArgOp.Pop());
                    arg1 = double.Parse(stackArgOp.Pop());
                    ans = arg1 / arg2;
                    stackArgOp.Push(ans.ToString());
                }
                else if (thisCh.Equals("^"))
                {
                    arg2 = double.Parse(stackArgOp.Pop());
                    arg1 = double.Parse(stackArgOp.Pop());
                    ans = Math.Pow(arg1, arg2);
                    stackArgOp.Push(ans.ToString());
                }
                else if (thisCh.Equals("+"))
                {
                    arg2 = double.Parse(stackArgOp.Pop());
                    arg1 = double.Parse(stackArgOp.Pop());
                    ans = arg1 + arg2;
                    stackArgOp.Push(ans.ToString());
                }
                else if (thisCh.Equals("-"))
                {
                    arg2 = double.Parse(stackArgOp.Pop());
                    arg1 = double.Parse(stackArgOp.Pop());
                    ans = arg1 - arg2;
                    stackArgOp.Push(ans.ToString());
                }
                else
                {
                    stackArgOp.Push(thisCh);
                }
            }

            var answer = stackArgOp.Pop();
            return double.Parse(answer);
        }
    }
}