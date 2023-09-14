using System.ComponentModel;

namespace Student_Application_App.Classes
{
    public class Calculator
    {
        private string Output(double x, double y, string symbol, double result)
        {
            return $"{x} {symbol} {y} = {result}";
        }
        public  void Add(double x, double y, out string result) => result = Output(x,y,"+", (x+y));
        public double Add(double x, double y) => x + y;

        public  void Subtract (double x, double y, out string result) => result = Output(x,y,"-", (x-y));
        public double Subtract(double x, double y) => x - y;

        public  void Multiply (double x, double y, out string result) => result = Output(x, y, "x", (x*y));
        public double Multiply(double x, double y) => x * y;

        public  void Divide (double x, double y, out string result) => result = Output(x,y,"/",(x/y));
        public double Divide(double x, double y) => x / y;

    }
}
