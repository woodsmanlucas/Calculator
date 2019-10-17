using System;

namespace Calculator
{
    class Program
    {
        public static double Add(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        public static double Minus(double num1, double num2)
        {
            return (num1 - num2);
        }

        public static double Times(double num1, double num2)
        {
            return (num1 * num2);
        }

        public static double div(double num1, double num2)
        {
            return (num1 / num2);
        }

        public static double rem(double num1, double num2)
        {
            return (num1 % num2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a calculation for example 1 + 2 (don't forget spaces) or press q to exit");
            String input = Console.ReadLine();
            while (!input.Equals("q"))
            { 
                
                string[] words = input.Split(' ');
                string op = words[1];
                double num1 = Convert.ToDouble(words[0]);
                double num2 = Convert.ToDouble(words[2]);
                if (op.Equals("+"))
                {
                    double sum = Add(num1, num2);
                    Console.WriteLine(sum);
                } else if (op.Equals("-")) {
                    Console.WriteLine(Minus(num1, num2));
                } else if (op.Equals("/"))
                {
                    Console.WriteLine(div(num1, num2));
                } else if (op.Equals("%"))
                {
                    Console.WriteLine(rem(num1, num2));
                } else if (op.Equals("*"))
                {
                    Console.WriteLine(Times(num1, num2));
                } else
                {
                    Console.WriteLine("Only the following operators are supported +, -, /, *, %");
                };
                input = Console.ReadLine();
            }
        }
    }
}
