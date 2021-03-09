using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitilized = false;

            isDeclaredAndInitilized = true;

        }
        [TestClass]
        public class Characters()
        {
        char character = 'a';
        char symbol = '?';
        char numbers = '7';
        char space = ' ';
        char specialCharacter = '\n';

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;
        }
        [TestMethod]

        public void WholeNumbers();
        {
         byte byteExample = 255;
        sbyte sByteExample = 127;
        short shortExample = 32767;
        Int16 anotherShortExample = 32000;
        int intmin = -2147483647;
        Int32 intMax = 2147483647;
        long longExample = 9223372036854775807;
        Int64 longMin = -9223372036854775807;

        int a = 15;
        int b = -15;
    }
    }
}




