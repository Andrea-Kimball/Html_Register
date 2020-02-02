using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void CheckSquareFootage()
        {
            RoomClass classroom = new RoomClass();
            classroom.Length = 10;
            classroom.Width = 10;

            int squarefootage = classroom.Calc();
            Console.WriteLine($"Actual square footage: {squarefootage}");

            Assert.AreEqual(100, squarefootage);

        }
    }
   
}

    
