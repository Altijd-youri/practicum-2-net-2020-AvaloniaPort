using System.Text;

namespace Lambda
{
    static class MethodRunner
    {
        public static string RunAllMethods(int numOne, int numTwo, int numThree)
        {
            var output = new StringBuilder();

            output.AppendFormat("TimesThree({0}) = {1}\n", numOne, Methods.TimesThree(numOne));
            output.AppendFormat("AddNumbers({0},{1},{2}) = {3}\n", numOne, numTwo, numThree, Methods.AddNumbers(numOne, numTwo, numThree));
            output.AppendFormat("IsEven({0}) = {1}\n", numOne, Methods.IsEven(numOne));
            output.AppendFormat("Num2String({0}) = {1}\n", numOne, Methods.Num2String(numOne));
            output.AppendFormat("InBetween({0},{1},{2}) = {3}\n", numOne, numTwo, numThree, Methods.InBetween(numOne, numTwo, numThree));
            
            var p = new Person {Name = "Jan"};
            Methods.ResetName(p);
            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n", p.Name == null);
            
            return output.ToString();
        }
    }
}
