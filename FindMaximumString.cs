using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumByGenerics
{
    public class FindMaximumString<T> where T : IComparable
    {
        public static T MaximumIntNumbers(T FirstString, T SecondString, T ThirdString)
        {
            if (FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) > 0 ||
                FirstString.CompareTo(SecondString) >= 0 && FirstString.CompareTo(ThirdString) >= 0 ||
                FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) >= 0)
            {
                Console.WriteLine(FirstString);
                return FirstString;
            }
            if (SecondString.CompareTo(FirstString) > 0 && SecondString.CompareTo(ThirdString) > 0 ||
                SecondString.CompareTo(FirstString) >= 0 && SecondString.CompareTo(ThirdString) >= 0 ||
                SecondString.CompareTo(FirstString) > 0 && SecondString.CompareTo(ThirdString) >= 0)
            {
                Console.WriteLine(SecondString);
                return SecondString;
            }
            if (ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(SecondString) > 0 ||
                ThirdString.CompareTo(FirstString) >= 0 && ThirdString.CompareTo(SecondString) >= 0 ||
                ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(SecondString) >= 0)
            {
                Console.WriteLine(ThirdString);
                return ThirdString;
            }
            return FirstString;
        }
    }
}
