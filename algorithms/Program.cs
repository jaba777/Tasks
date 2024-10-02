using algorithms.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var firstTask = Task1.ChangeMeaning(3, 5);
            //Console.WriteLine($"First Value: {firstTask.Item1} {firstTask.Item2}");

            //var maxNumber = Task1.MaxNumber(20, 15, 10);

            //Console.WriteLine($"Max Number: {maxNumber}");

            //var minNumber = Task1.MinNumber(20, 15, 10);

            //Console.WriteLine($"Min Number: {minNumber}");

            //var evenNumber = Task1.NumberIsEven(5);
            //Console.WriteLine(evenNumber);

            //var factorial = Task1.Factorial();
            //Console.WriteLine(factorial);


            //var triangleCondition = Task1.TriangleCondition(5, 6, 7);
            //Console.WriteLine($"Triangle condition: {triangleCondition}");

            //var primeNumber = Task1.PrimeNumber(7);

            //Console.WriteLine(primeNumber);

            //var perfectNumber = Task1.Perfectnumber();

            //Console.WriteLine(perfectNumber);

            //double[] numbers = { 1.5, 2.3, 0.8, 3.7, 2.9,5,6,7,8,15,15.6 };


            //var maxNumberFromArray = Task1.MaxNumberFromArray(numbers);
            //Console.WriteLine($"Max number from array is: {maxNumberFromArray}");

            //int[] intIumbers = {  5, 6, 7, 8, 15,2,6,3,1,4,5 };

            //var countOfEvenAndOdd = Task1.CountOfEvenAndOdd(intIumbers);
            //Console.WriteLine(countOfEvenAndOdd);

            //var evenNumbers = Task1.EvenNumbers(intIumbers);
            //Console.WriteLine($"Even numbers are: {string.Join(", ", evenNumbers)}");

            //uint[] arrayOfPrimeFunction  = { 1,3,5,6,7,9,10,13,11,12 };

            //var primeArr = Task1.PrimeNumbers(arrayOfPrimeFunction);
            //Console.WriteLine($"Prime numbers are: {string.Join(", ", primeArr)}");

            //var solveQuadraticEquation = Task1.SolveQuadraticEquation();
            //Console.WriteLine(solveQuadraticEquation);



            //Circle circle = new Circle();
            //Console.Write("Enter the radius of the circle: ");
            //double radiusInput = double.Parse(Console.ReadLine());

            //if(radiusInput.GetType() == typeof(double))
            //{
            //    circle.SetRadius(radiusInput);
            //    double area = circle.GetArea();
            //    double perimeter = circle.GetPerimeter();

            //    Console.WriteLine($"Area: {area}");
            //    Console.WriteLine($"Perimeter: {perimeter}");
            //}



            //MyCalculator calculator = new MyCalculator();

            //while (true)
            //{
            //    Console.WriteLine("Type C to continue the program, X to end");
            //    string userInput = Console.ReadLine();

            //    if (userInput.ToUpper() == "X")
            //    {
            //        break; // End the program
            //    }
            //    if (userInput.ToUpper() == "C")
            //    {
            //        Console.WriteLine("Enter the first number");

            //        double firstNum = double.Parse(Console.ReadLine());
            //        if (firstNum.GetType() != typeof(double))
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number.");
            //            continue;

            //        }

            //        Console.WriteLine("Enter the second number");

            //        double secondNum = double.Parse(Console.ReadLine());
            //        if (secondNum.GetType() != typeof(double))
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number.");
            //            continue;

            //        }

            //        Console.WriteLine("Next message: enter operation + - * / .");
            //        string operation = Console.ReadLine();

            //        double result = calculator.CalculatorFunc(firstNum, secondNum,operation);

            //        Console.WriteLine($"result is {result}");


            //    }
            //}


            //var game = Game.game();
            //Console.WriteLine(game);

            var shop = Shop.MyShop();

            Console.WriteLine(shop);

        }
    }
}
