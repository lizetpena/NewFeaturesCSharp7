using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7Features
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Tuples();
        }

        void OldOutVariables(string input)
        {
            int result;
            if (int.TryParse(input, out result))
                WriteLine(result);
            else
                WriteLine("Could not parse input");
        }

        // You can now declare out variables in the argument list of a
        // method call, rather than writing a separate declaration statement
        void NewOutVariable(string input)
        {
            if (int.TryParse(input, out int result))
                WriteLine(result);
            else
                WriteLine("Could not parse input");
            WriteLine(result);
        }

        void Tuples()
        {
            // simple tuple
            var letters = ("a", 123.4, 1, 2, 4);

            WriteLine(letters);
            WriteLine(letters.Item1);

            // assigning names
            (string Alpha, double Beta) namedLetters = ("c", 123.4);
            WriteLine(namedLetters);
            WriteLine(namedLetters.Alpha);

            // assignment by position
            (string First, string Second) firstLetters = (Alpha: "e", Beta: "f");

            WriteLine(firstLetters.First);

            // tuple as return type into locals
            int[] data = new int[] { 4, 7, 2, 5, 8, 9 };
            var range = Range(data);          
            (int max, int min) = Range(data);

            Console.WriteLine(min);
            Console.WriteLine(max);

            // deconstruction of a tuple
            var tup = (3.14, "2.71");
            (double a, string b) = tup;

           

            WriteLine(a);
            WriteLine(b);

            //passing a tuple by value on a method
            ModifyTuple(tup);
            WriteLine("Tuple tup passed to method");
            WriteLine(tup.Item1);
            WriteLine(tup.Item2);


            // deconstruction of a class like a tuple
            Point p = new Point(3.14, 2.71);
            (double left, double top) = p;
            WriteLine(left);
            WriteLine(top);
        }

        private void ModifyTuple((double, string) tup)
        {
            tup.Item1 = 4.44;
            tup.Item2 = "Modified";
            
        }

        (int Max, int Min) Range(IEnumerable<int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var n in numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }
            return (max, min);
        }

        public static int sum(int x, int y)
        {
            if (x < 0)
            {
                return y + x;
            }
            else if (x > 100)
            {
                return 5;
            }
            else
            {
                return x + y;
            }
        }
    }

    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public void Deconstruct(out double x, out double y)
        {
            x = this.X;
            y = this.Y;
        }
    }

}
