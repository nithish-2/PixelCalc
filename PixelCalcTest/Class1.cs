using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PixelCalc;

namespace PixelCalc
{
    public class Class1
    {
        [Test]
        public void DiagonalCalculation_Input20and10and31_OutputValidDiagonal()
        {
            // Arrange
            double screenWidth = 20;
            double screenHeight = 10;
            double diagonalInInches = 31;

            // Act
            double actualDiagonalInPixels = PixelCalc.DiagonalInPixelCalculation(screenWidth, screenHeight, diagonalInInches);

            // Assert
            Assert.AreEqual(22, actualDiagonalInPixels);
        }
    }
}
