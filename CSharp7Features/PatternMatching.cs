using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp7Features
{
    class PatternMatching
    {
        public static int DiceSum1(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                if (item is int)
                {
                    int val = (int)item;
                    sum += val;
                }
                else if (item is IEnumerable<object> subList)
                    sum += DiceSum1(subList);
            }
            return sum;
        }

        public static int DiceSum2(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                if (item is int val)
                    sum += val;
                else if (item is IEnumerable<object> subList)
                    sum += DiceSum2(subList);
            }
            return sum;
        }

        public static int DiceSum3(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case int val:
                        sum += val;
                        break;
                    case IEnumerable<object> subList:
                        sum += DiceSum3(subList);
                        break;
                }
            }
            return sum;
        }

        public static int DiceSum4(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case 0:
                        break;
                    case int val:
                        sum += val;
                        break;
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum4(subList);
                        break;
                    case IEnumerable<object> subList:
                        break;
                    case null:
                        break;
                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
            return sum;
        }

        public void PrintStars(object o)
        {
            if (o is null)
                return;     // constant pattern "null"

            if (!(o is int i))
                return; // type pattern "int i"

            WriteLine(new string('*', i));
        }

        public void PatternMatchingWithTry(object o)
        {
            if (o is int i || (o is string s && int.TryParse(s, out i)))
            {
                WriteLine(i * 10);
            }
        }
    }
}
