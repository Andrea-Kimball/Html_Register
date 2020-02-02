using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesandVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Andrea";
            string lastName = "Kimball";
            string concatenatedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenatedFullName);

            string compositeFullName = string.Format("Hello, {0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullName);

            string interpolatedFullName = $"Hey {firstName} {lastName}! Whats new?";
            Console.WriteLine(interpolatedFullName);
        }
        [TestMethod]
        public void Collections()
        {
            //array
            string stringExample = "Hello World!";
            string[] stringArray = { "Hello", "World", "why", "is it", "always", stringExample ,"?" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[0] = "hey there!";
            Console.WriteLine(stringArray[0]);

            //List
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("words are hard");
            listOfIntegers.Add(32);

            //Queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next in line");
            string firstItem = firstInFirstOut.Dequeue();

            //Dictionary
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(22, "Reagan");
            string value22 = keyAndValue[22];
            Console.WriteLine(value22);

            SortedList<int, string> sortedKeyandValuePair = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }

        [TestMethod]
        public void AmandasReferenceTypesChallenge()
        {
            string color = "gold";
            string welcomeMessage = ("Welcome to our " + color + " membership status");
            string spamMessage = ("Please reply to this email with your SSN to join our " + color + " membership status");
            string randomSentence = (color + " is a color");
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(spamMessage);
            Console.WriteLine(randomSentence);

            string secondFav = "wings";
            string iDontLike = "beer";

            string randomSent = string.Format("A classic combo is {0} and {1}", secondFav, iDontLike);
            Console.WriteLine(randomSent);

            string hatType = "baseball cap";
            string HatTypetwo = "bowler";
            string HatTypeThree = "cowboy hat";
            string randomHatSent = ($"my favorite type of hat is {hatType}, but I think i might look good in a {HatTypetwo} or {HatTypeThree}");
            Console.WriteLine(randomHatSent);    
            
            string[] letters ={ "L", "X", "R", "Z","Q"};
            string thirdItem = letters[2];
            Console.WriteLine(thirdItem);

            List<string> listOfFruit = new List<string>();

        }
    }
}
