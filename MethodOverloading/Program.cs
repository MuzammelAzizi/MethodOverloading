using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 4;
            var y = 5;
            var intAdd = Add(x, y);
            Console.WriteLine(intAdd);

            var a = 10.00m;
            var b = 30.00m;
            var decAdd = Add(a, b);

            var addWithBool = Add(x, y);
            Console.WriteLine(addWithBool);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static String Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;
            if(isTrue && sum > 1) 
            {
                return $"{sum} dollars";
            }
            else if (isTrue && sum > 1) 
            {
                return $"{sum} dollar";
            }
            else 
            {
                return $"{sum}";
            }
        }
        

        
    }
}
