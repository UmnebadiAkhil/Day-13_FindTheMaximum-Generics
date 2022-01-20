// See https://aka.ms/new-console-template for more information
using FindMaximumByGenerics;
using System.Collections.Generic;
using System.Text;

bool flag = true;
while (flag)
{
    Console.WriteLine("Enter the Program that want to be executed : \n 1. Find Maximum Integer \n 2. Find Maximum Float \n 3. Maximum String \n 4. Exit");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Enter First number, Second number, Third number : ");
            int FirstValue = Convert.ToInt32(Console.ReadLine());
            int SecondValue = Convert.ToInt32(Console.ReadLine());
            int ThirdValue = Convert.ToInt32(Console.ReadLine());
            int result = FindMaximumNumber<int>.MaximumIntNumbers(FirstValue, SecondValue, ThirdValue);
            Console.WriteLine("Maximum Number is : " + result);
            break;
        case 2:
            Console.WriteLine("Enter First number, Second number, Third number to check : ");
            double FirstNumber = Convert.ToDouble(Console.ReadLine());
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            double ThirdNumber = Convert.ToDouble(Console.ReadLine());
            int result1 = (int)FindMaximumFloatNumber<double>.MaximumDoubleNumbers(FirstNumber, SecondNumber, ThirdNumber);
            Console.WriteLine("The Maximum Number is : " + result1);
            break;
        case 3:
            Console.WriteLine("Enter Three Strings to check : ");
            string FirstString = Convert.ToString(Console.ReadLine());
            string SecondString = Convert.ToString(Console.ReadLine());
            string ThirdString = Convert.ToString(Console.ReadLine());
            string largest = FindMaximumString<string>.MaximumIntNumbers(FirstString, SecondString, ThirdString);
            Console.WriteLine("The Largest String is : " + largest);
            break;
        case 4:
            flag = false;
            break;
    }
}