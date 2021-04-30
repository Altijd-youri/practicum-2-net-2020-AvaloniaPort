using System;
using System.Text;

namespace Lambda
{
    static class LambdaRunner
    {
        public static string RunAllMethods(int numOne, int numTwo, int numThree)
        {
            var output = new StringBuilder();

            // TimesThree rewritten as a lambda expression would look like the following:
            // Func<int, int> timesThree = x => 3 * x;
                        
            Func<int, int> timesThree = x => 3 * x;
            output.AppendFormat("x => 3 * x, met x={0} = {1}", numOne, timesThree(numOne)); 

            // ... Rewrite all the other methods as a lambda expression (or local function)

            return output.ToString();
        }
    }
}
