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

            string expected = "22";

            // Act
            string actual = PixelCalc.DiagonalInPixelCalculation(screenWidth, screenHeight, diagonalInInches);

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

            string expected = "1.73";

            // Act
            string actual = PixelCalc.PPICalculation(screenWidth, screenHeight, diagonalInInches);

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


            string expected = "18.118";

            // Act
            string actual = PixelCalc.DotPitchCalculation(screenWidth, screenHeight, diagonalInInches);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PPICalcWithNegativeInputs_Input25and20and90_OutputValidPPI()
        {
            // Arrange
            double screenWidth = -25;
            double screenHeight = 20;
            double diagonalInInches = 90;


            string expected = "Please provide inputs greater than zero";

            // Act
            string actual = PixelCalc.PPICalculation(screenWidth, screenHeight, diagonalInInches);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
