using System.ComponentModel;

namespace Student_Application_App.Classes
{
    public static class StaticCalculator
    {
        private static string Output(double x, double y, string symbol, double result)
        {
            return $"{x} {symbol} {y} = {result}";
        }
        public static void Add(double x, double y, out string result) => result = Output(x,y,"+", (x+y));
        public static double Add(double x, double y) => x + y;

        public static void Subtract (double x, double y, out string result) => result = Output(x,y,"-", (x-y));
        public static double Subtract(double x, double y) => x - y;

        public static void Multiply (double x, double y, out string result) => result = Output(x, y, "x", (x*y));
        public static double Multiply(double x, double y) => x * y;

        public static void Divide (double x, double y, out string result) => result = Output(x,y,"/",(x/y));
        public static double Divide(double x, double y) => x / y;

    }
}
