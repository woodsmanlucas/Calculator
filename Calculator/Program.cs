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
            double Ans = 0;
            try
            {
                Ans = (num1 - num2);
            }
            catch (NotFiniteNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            return Ans;
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
            double Ans = 0;
            bool error = false;
            while (!input.Equals("q"))
            {

                string[] words = input.Split(' ');
                if (words.Length > 2)
                {
                    string op = words[1];
                    double num1 = 1;
                    if (words[0] == "Ans")
                    {
                        num1 = Ans;
                    }
                    else
                    {
                        try
                        {
                            num1 = Convert.ToDouble(words[0]);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            error = true;
                        }
                    }
                    double num2 = 1;
                    if (words[2] == "Ans")
                    {
                        num2 = Ans;
                    }
                    else
                    {
                        try
                        {
                            num2 = Convert.ToDouble(words[2]);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    if (op.Equals("+"))
                    {
                        Ans = Add(num1, num2);
                    }
                    else if (op.Equals("-"))
                    {
                        Ans = Minus(num1, num2);
                    }
                    else if (op.Equals("/"))
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("Please don't do that");
                            error = true;
                        }
                        else
                        {
                            Ans = div(num1, num2);
                        }
                    }
                    else if (op.Equals("%"))
                    {
                        Ans = rem(num1, num2);
                    }
                    else if (op.Equals("*"))
                    {
                        Ans = Times(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Only the following operators are supported +, -, /, *, %");
                        error = true;
                    };
                    if (error == false)
                    {
                        Console.WriteLine(Ans);
                    }
                }
                else
                {
                    Console.WriteLine("Please use spaces and type two numbers with an operator in between");
                }


                input = Console.ReadLine();

            }
        }
    }
}
