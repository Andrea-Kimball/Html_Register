using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    public class RoomClass
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public int Calc()
        {
            int SquareFootage = Length * Width;
            return SquareFootage;
        }

        public int CalcLateralSurface()
        {
            int LengthLSA = Length * Height * 2;
            int WidthLSA = Width * Height * 2;
            int TotalLSA = LengthLSA + WidthLSA;
            return TotalLSA;
        }

    }
}
