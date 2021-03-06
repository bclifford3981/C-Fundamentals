using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisionOpperators()
        {

            //start w/ our variables
            int age = 25;
            string userName = "Ben";

            //check to see if something is = to something else

            bool equals = age == 41;
            Console.WriteLine(equals);

            bool userIsBen = userName == "Ben";
            Console.WriteLine(userIsBen);
            Console.WriteLine("User is 41:" + equals);

            // using the '!' (bang) operator
            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: {notEqual} ");

            bool userIsNotJustion = userName != "Justion";
            Console.WriteLine(userIsNotJustion);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            // compare the list

            bool listAreEqual = firstList.Count == secondList.Count;
            Console.WriteLine($"The list are equal?: {listAreEqual}");

            //greater than
            bool greaterThan = age > 12;

            //greater than or equal to 
            bool greaterThanOrEqual = age >= 24;
            Console.WriteLine(greaterThanOrEqual);

            //less than
            bool lessThan = age < 66;
            Console.WriteLine(lessThan);

            //less than or equal to 
            bool lessThanOrEqualTo = age <= 24;
            Console.WriteLine(lessThanOrEqualTo);


            //we have the or '||'
            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            Console.WriteLine($"True or True {tOrT}");
            Console.WriteLine($"True or False {tOrF}");
            Console.WriteLine($"False or True {fOrT}");
            Console.WriteLine($"False or False {fOrF}");





        }
    }
}
