using System;
using System.ComponentModel;
using System.Security;

namespace ConsoleApp8
{
    internal class Program
    {
        
        static void Main(string[] args)
        { //part 1
            #region 1

            //    int valType = 5;
            //    ModifyValue(valType);
            //    Console.WriteLine("Value after passing by value: " + valType); 

            //    int refType = 5;
            //    ModifyReference(ref refType);
            //    Console.WriteLine("Value after passing by reference: " + refType); 
            //}


            //static void ModifyValue(int number)
            //{
            //    number = 10;
            //}


            //static void ModifyReference(ref int number)
            //{
            //    number = 10;
            //}
            //}

            #endregion


            #region 2


            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    int sum = CalculateSumOfDigits(number);
            //    Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");


            //static int CalculateSumOfDigits(int num)
            //{
            //    int sum = 0;
            //    while (num != 0)
            //    {
            //        sum += num % 10; 
            //        num /= 10;      
            //    }
            //    return sum;
            //}
            #endregion

            #region 3

            //Console.WriteLine(isprime(9));



            //static bool isprime(int x)
            //{
            //    if (x <=1)               
            //    {
            //        return false;
            //    }
            //    for (int i = 2; i <= Math.Sqrt(x); i++) 
            //    { 
            //        if (x % i == 0) 
            //        { 
            //            return false; 
            //        } 
            //    }
            //    return true;
            //}
            #endregion

            #region 4

            //static void MinMaxArray(int[] arr, ref int min, ref int max)
            //{
            //    min = int.MaxValue;
            //    max = int.MinValue;
            //    foreach (int num in arr)
            //    {
            //        if (num < min)
            //            min = num;
            //        if (num > max)
            //            max = num;
            //    }
            //}

            //    int[] arr = { 5, 3, 9, 1, 6, 8 };
            //    int min = 0, max = 0;
            //    MinMaxArray(arr, ref min, ref max);
            //    Console.WriteLine("Minimum value: " + min);
            //    Console.WriteLine("Maximum value: " + max);


            #endregion

            #region 5
            //Console.WriteLine(Factorial(5));
            //static int Factorial(int number) 
            //{ 
            //    int result = 1; 
            //    for (int i = 1; i <= number; i++) 
            //    { 
            //        result *= i; 
            //    }
            //    return result; 
            //}
            #endregion

            #region 6

            // -----------------------
            #endregion


            #region 7
            //static void sumsub(int a,int b,int c,int d)
            //{
            //    int sum;
            //    sum =a + b ;
            //    Console.WriteLine(sum);
            //    int sub;
            //    sub = c - d ;
            //    Console.WriteLine(sub);

            //}

            // sumsub(1,5,3,6);

            #endregion

            #region 8

            //static string ChangeChar(string input, int position, char newChar)
            //{
            //    if (position < 0 || position >= input.Length)
            //    {
            //       Console.WriteLine(nameof(position), "Position is out of range.");
            //    }

            //    char[] charArray = input.ToCharArray();
            //    charArray[position] = newChar;
            //    return new string(charArray);
            //}


            //    string originalString = "hello";
            //    int position = 1; 
            //    char newChar = 'a';

            //    string modifiedString = ChangeChar(originalString, position, newChar);
            //    Console.WriteLine("Original string: " + originalString);
            //    Console.WriteLine("Modified string: " + modifiedString);

            #endregion
            //part 2
            #region 1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region 2
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(userInput, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Unknown season");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}
            #endregion


            #region 4
           
            #endregion
        }

   

     enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

   
         


     enum Season
    {
        Spring,
        Summer,
            Autumn,
        Winter
        }

    
     




    }
}


