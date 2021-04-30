namespace Lambda
{
    static class Methods
    {
        public static int TimesThree(int x)
        {
            return x * 3;   
        }

        public static int AddNumbers(int x, int y, int z)
        {
            return x + y + z;
        }

        public static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        public static string Num2String(int x)
        {
            // This can be written in a nicer way using a switch expression:
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression
            
            switch (x)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "undefined";
            }
        }

        public static bool InBetween(int x, int y, int z) {
            return x < y && y < z;
        }

        public static void ResetName(Person p)
        {
            p.Name = null;
        }
    }
}
