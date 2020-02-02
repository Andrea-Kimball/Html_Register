using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                iterator = iterator + 1;
                // (or iterator++;)
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My doWhile Condition is false.");
            }
            while (false);
        }
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 34;
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Craig", "Justin", "Isaiah" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class {students[i]}!");
            }
        }
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total++;
            }

            Random rand = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                    //break; (also works)
                }
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            string[] students = { "Nick", "Craig", "Justin", "Isaiah", "Tom", "Un Yon", "Josh" };

            foreach (string student in students)
            {
                Console.WriteLine(student + " is a child");
            }

            string myName = "Andrea Kimball";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }
        [TestMethod]
        public void Challenge()
        {  // TYPE  NAME   =    VALUE     
            string custKey = "";
            string possibleCharacters = "BCDFGHJKLMNPQRSTVWXYZ123456789";

            Random rand = new Random();

            while (custKey.Length < 10)
            {
            int randomNumber = rand.Next(0, possibleCharacters.Length);
            char nextCharacter = possibleCharacters[randomNumber];
                if (custKey.EndsWith("1")&& nextCharacter == '3')
                {
                    continue;
                }

            custKey = custKey + nextCharacter;
            }
            Console.WriteLine(custKey);

            }
        }
        //Do this on your own!
        //Your client needs a secure key for their website's customers. 
        //You need to write the code that generates a string that has 10 random alphanumeric characters. 
        //Your client would like the each code to not include any vowels. 
        //He also hates the number 13, so make sure none of your codes include the number 13!
         
        }
    
