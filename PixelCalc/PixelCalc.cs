using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCalc
{
    public static class PixelCalc
    {
        public static double DiagonalInPixelCalculation(double screenWidth, double screenHeight, double diagonalInInches)
        {
            //performs diagonal in pixels, PPI, dot pitch calculation  
            double diagonalInPixels = Math.Sqrt((screenWidth * screenWidth) + (screenHeight * screenHeight));
            double PPI = diagonalInPixels / diagonalInInches;
            double dotPitch = (diagonalInInches / diagonalInPixels) * 25.4;

            //returns calculated value
            return Math.Round(diagonalInPixels);
        }

        public static double PPICalculation(double screenWidth, double screenHeight, double diagonalInInches)
        {
            //performs diagonal in pixels, PPI, dot pitch calculation  
            double diagonalInPixels = Math.Sqrt((screenWidth * screenWidth) + (screenHeight * screenHeight));
            double PPI = diagonalInPixels / diagonalInInches;
            double dotPitch = (diagonalInInches / diagonalInPixels) * 25.4;

            //returns calculated value
            return Math.Round(PPI, 2);
        }

        public static double DotPitchCalculation(double screenWidth, double screenHeight, double diagonalInInches)
        {
            //performs diagonal in pixels, PPI, dot pitch calculation  
            double diagonalInPixels = Math.Sqrt((screenWidth * screenWidth) + (screenHeight * screenHeight));
            double PPI = diagonalInPixels / diagonalInInches;
            double dotPitch = (diagonalInInches / diagonalInPixels) * 25.4;

            //returns calculated value
            return Math.Round(dotPitch, 4);
        }
    }
}
