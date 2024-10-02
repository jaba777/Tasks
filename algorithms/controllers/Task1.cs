using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.controllers
{
    internal class Task1
    {
        public static (int,int) ChangeMeaning(int a,int b)
        {
            int c = a;
            a = b;
            b = c;
            return (a,b);
        }

        public static int MaxNumber(int a, int b, int c)
        {
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if(max < c)
            {
                max = c;
            }
            return max;
        }

        public static int MinNumber(int a, int b, int c)
        {
            int max = a;
            if (max > b)
            {
                max = b;
            }
            if (max > c)
            {
                max = c;
            }
            return max;
        }

        public static string NumberIsEven(int a)
        {
            bool isEven=IsEven(a);
            if (isEven)
                return $"{a} is even.";
            else
                return $"{a} is odd.";
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }


        public static string Factorial()
        {
            Console.WriteLine("Enter a number: ");
            uint number = Convert.ToUInt32(Console.ReadLine());

            uint result = 1;

            for(uint i=1; i <= number; i++)
            {
                result *= i;
            }

            return $"The factorial of {number} is {result}";
        }

        public static bool TriangleCondition(double a,double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public static string PrimeNumber(int a)
        {
            double divideNumber = a / 2;
            int divideAndFloor = (int)Math.Floor(divideNumber);
            bool isPrime = true;

            for(int i =2; i<=divideAndFloor; i++)
            {
                if(a%i == 0)
                {
                    isPrime = false ;
                    break;
                }
            }



            return isPrime ? $"Number {a} is Primary" : $"Nnumber {a} isnt primary";
        }

        public static string Perfectnumber()
        {
            Console.WriteLine("Enter a number: ");
            uint number = Convert.ToUInt32(Console.ReadLine());
            uint sumOfDivisors = 0;

            for(uint i=1; i < number; i++)
            {
                if(number%i == 0)
                {
                    sumOfDivisors += i;
                }
            }
           
            return number == sumOfDivisors ? $"number {number} is primary" : $"number {number} is not primary";
        }

        public static double MaxNumberFromArray(double[] array)
        {
            double max = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static string CountOfEvenAndOdd(int[] array)
        {
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
                return $"Count of even is {evenCount} and Count of odd is {oddCount}";

        }
        public static int[] EvenNumbers(int[] array)
        {
            List<int> arr = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                   arr.Add(array[i]);
                }
               
            }

            return arr.ToArray();
        }

        public static uint[] PrimeNumbers(uint[] array)
        {
            List<uint> primeArray = new List<uint>();

            for (int i = 0; i < array.Length; i++)
            {
                bool isPrime = true;
                for(uint j = 2; j < array[i]; j++)
                {
                    if (array[i] % j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeArray.Add(array[i]);
                }
            }

            return primeArray.ToArray();
        }

        public static string SolveQuadraticEquation()
        {
            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            double X1, X2;

            if (discriminant > 0)
            {
                // Two real roots
                 X1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                 X2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

                return $"Two real roots: x1 = {X1}, x2 = {X2}";
            }
            else if (discriminant == 0)
            {
                // One real root
                 X1 = -b / (2 * a);
                return $"One real root: x1 = {X1}";
            }


            return "The equation has complex roots";
        }
    }
}
