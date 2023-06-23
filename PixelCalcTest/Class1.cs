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

            double expected = 22;

            // Act
            double actual = PixelCalc.DiagonalInPixelCalculation(screenWidth, screenHeight, diagonalInInches);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PPICalcWithPositiveInputs_Input45and43and36_OutputValidPPI()
        {
            // Arrange
            double screenWidth = 45;
            double screenHeight = 43;
            double diagonalInInches = 36;

            double expected = 1.73;

            // Act
            double actual = PixelCalc.PPICalculation(screenWidth, screenHeight, diagonalInInches);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DotPitchCalcWithPositiveInputs_Input58and21and44_OutputValidDotPitch()
        {
            // Arrange
            double screenWidth = 58;
            double screenHeight = 21;
            double diagonalInInches = 44;


            double expected = 18.118;

            // Act
            double actual = PixelCalc.DotPitchCalculation(screenWidth, screenHeight, diagonalInInches);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
