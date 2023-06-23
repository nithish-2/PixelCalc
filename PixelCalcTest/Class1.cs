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
        public void DiagonalCalcWithPositiveInputs_Input20and10and31_OutputValidDiagonal()
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

        [Test]
        public void PPICalcWithPositiveInputs_Input45and43and36_OutputValidPPI()
        {
            // Arrange
            double screenWidth = 45;
            double screenHeight = 43;
            double diagonalInInches = 36;

            // Act
            double actualDiagonalInPixels = PixelCalc.PPICalculation(screenWidth, screenHeight, diagonalInInches);

            // Assert
            Assert.AreEqual(1.73, actualDiagonalInPixels);
        }
    }
}
