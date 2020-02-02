using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesandVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclarationAndInitialized = true;
        }
        [TestMethod]
        public void Characters()
        {
            //characters are one letter,number or symbol inside single quotes
            char character = 'a';
            char number = '1';
            char symbol = '@';
            char space = ' ';
            char specialCharacter = '\n'; //new line

        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 15;
            int b = 22;
            int c = 37;
            byte age = 64;

        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.045231587612d;
            decimal decimalExample = 1.257958797897897890457897m;

            Console.WriteLine(decimalExample);

        }

        enum PastryType { cake,danish, donut, pie, scone, cupcakes}

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.donut;
            PastryType secondPastry = PastryType.scone;
            PastryType thirdPastry = PastryType.cake;

            Console.WriteLine(myPastry);
            Console.WriteLine(secondPastry);

        }
        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

            DateTime birthday = new DateTime(2020, 11, 24);
            Console.WriteLine(birthday);
        }

        enum ColorType { red, blue, green, purple, yellow, orange }


        //Challenges start here


        [TestMethod]
        public void Challenges()
        {
            ColorType favColor = ColorType.blue;
            ColorType secondFav = ColorType.green;
            ColorType thirdFav = ColorType.purple;

            Console.WriteLine(favColor);
            Console.WriteLine(secondFav);
            Console.WriteLine(thirdFav);

           
        }
        [TestMethod]
        public void BoolChallenges()
        {
            bool isFun;
            isFun = true;

            bool isHappy;
            isHappy = false;

            bool isSleepy;
            isSleepy = true;

            bool isHungry;
            isHungry = true;

            bool isReady;
            isReady = false;
        }

        [TestMethod]
        public void AmandasValueTypesChallenge()
        {
            string varNumOne;
            string varNumTwo = "Variable Number Two";
            char Anna;
            char Brad = 'b';
            decimal varNumberFour = 1.24m;
            decimal varNumberFive = 7.96m;
            bool restName = true;
        }

        }
}
