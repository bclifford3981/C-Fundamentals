using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //Addition '+'
            int sum = a + b;
            //this is shorthand addition
            sum += 3;
            Console.WriteLine($"sum: {sum}");

            //subtraction
            int difference = a - b;
            //difference -=3;
            sum -= 3;
            Console.WriteLine($"difference: {difference}");

            //Multiplication '*'
            int product = a * b;
            //product*=3;
            Console.WriteLine($"product: {product}");

            //division '/'
            int quotient = a / b;
            Console.WriteLine($"quotient: {quotient}");

            //modulus
            int remainder = a % b;
            Console.WriteLine($"remainder: {remainder}");

            DateTime now = DateTime.Now;
            DateTime sometime = new DateTime(1998, 3, 23);

            TimeSpan timeSpan = now - sometime;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalMilliseconds);

            //--------------------------------------------




        }
    }
}
