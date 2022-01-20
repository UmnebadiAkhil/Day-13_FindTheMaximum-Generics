using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumByGenerics
{
    public class FindMaximumFloatNumber<T> where T : IComparable
    {
        public static T MaximumDoubleNumbers(T FirstNumber, T SecondNumber, T ThirdNumber)
        {
            if (FirstNumber.CompareTo(SecondNumber) > 0 && FirstNumber.CompareTo(ThirdNumber) > 0 ||
                FirstNumber.CompareTo(SecondNumber) >= 0 && FirstNumber.CompareTo(ThirdNumber) >= 0 ||
                FirstNumber.CompareTo(SecondNumber) > 0 && FirstNumber.CompareTo(ThirdNumber) >= 0)
            {
                Console.WriteLine(FirstNumber);
                return FirstNumber;
            }
            if (SecondNumber.CompareTo(FirstNumber) > 0 && SecondNumber.CompareTo(ThirdNumber) > 0 ||
                SecondNumber.CompareTo(FirstNumber) >= 0 && SecondNumber.CompareTo(ThirdNumber) >= 0 ||
                SecondNumber.CompareTo(FirstNumber) > 0 && SecondNumber.CompareTo(ThirdNumber) >= 0)
            {
                Console.WriteLine(SecondNumber);
                return SecondNumber;
            }
            if (ThirdNumber.CompareTo(FirstNumber) > 0 && ThirdNumber.CompareTo(SecondNumber) > 0 ||
                ThirdNumber.CompareTo(FirstNumber) >= 0 && ThirdNumber.CompareTo(SecondNumber) >= 0 ||
                ThirdNumber.CompareTo(FirstNumber) > 0 && ThirdNumber.CompareTo(SecondNumber) >= 0)
            {
                Console.WriteLine(ThirdNumber);
                return ThirdNumber;
            }
            return FirstNumber;
        }
    }
}
