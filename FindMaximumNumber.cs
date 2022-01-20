using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumByGenerics
{
    public class FindMaximumNumber<T> where T: IComparable
    {
        public static T MaximumIntNumbers(T FirstValue, T SecondValue, T ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
                FirstValue.CompareTo(SecondValue) >= 0 && FirstValue.CompareTo(ThirdValue) >= 0 ||
                FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) >= 0)
            {
                Console.WriteLine(FirstValue);
                return FirstValue;
            }
            if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValue) >= 0 && SecondValue.CompareTo(ThirdValue) >= 0 ||
                SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                Console.WriteLine(SecondValue);
                return SecondValue;
            }
            if (ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0 ||
                ThirdValue.CompareTo(FirstValue) >= 0 && ThirdValue.CompareTo(SecondValue) >= 0 ||
                ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) >= 0)
            {
                Console.WriteLine(ThirdValue);
                return ThirdValue;
            }
            return FirstValue;
        }

    }
}
