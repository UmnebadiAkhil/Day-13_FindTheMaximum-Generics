using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumByGenerics
{
    public class Reactor_1<T> where T : IComparable
    {
        public T firstvalue, secondvalue, thirdvalue;

        public Reactor_1(T firstvalue, T secondvalue, T thirdvalue)
        {
            this.firstvalue = firstvalue;
            this.secondvalue = secondvalue;
            this.thirdvalue = thirdvalue;
        }

        public static T MaximumValue(T firstvalue, T secondvalue, T thirdvalue)
        {if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thirdvalue) >= 0 ||
                firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine(firstvalue);
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thirdvalue) >= 0 ||
                secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) >= 0)
            {
                Console.WriteLine(secondvalue);
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0 ||
                thirdvalue.CompareTo(firstvalue) >= 0 && thirdvalue.CompareTo(secondvalue) >= 0 ||
                thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) >= 0)
            {
                Console.WriteLine(thirdvalue);
                return thirdvalue;
            }
            return firstvalue;
        }

        public T MaxMethod()
        {
            T max = Reactor_1<T>.MaximumValue(this.firstvalue, this.secondvalue, this.thirdvalue);
            return max;
        }
    }
}
