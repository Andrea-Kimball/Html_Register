using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Method
{
    [TestClass]
    public class MethodExamples
    {
        //1     2       3
        public void SayHello(string name)
        //1-access modifier
        //2-return type 
        //3-method signature
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        //method overload we can use Add again because we are using a different... (type?)
        public double Add(double numberOne, double numberTwo)
        {
            double total = numberOne + numberTwo;
            return total;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            double floorAge = Math.Floor(totalAgeInYears);
            int years = Convert.ToInt32(floorAge);
            //int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }

        public int Multiply(int numThree, int numFour)
        {
            int clean = numThree * numFour;
            return clean;
        }


        [TestMethod]
        public void MethodExecution()
        {
            SayHello("George");
            SayHello("Josh");

            int sum = Add(23, 86);
            Console.WriteLine(sum);

            int clean = Multiply(15, 53);
            Console.WriteLine(clean);

            double total = Add(16, 32);
            Console.WriteLine(total);

            DateTime birthdate = new DateTime(1944, 12, 24);
            Console.WriteLine(CalculateAge(birthdate));

        }


    }
}