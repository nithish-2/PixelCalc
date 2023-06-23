using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PixelCalc
{
    public static class PixelCalc
    {
        public static string DiagonalInPixelCalculation(double screenWidth, double screenHeight, double diagonalInInches)
        {
            //performs diagonal in pixels, PPI, dot pitch calculation  
            double diagonalInPixels = Math.Sqrt((screenWidth * screenWidth) + (screenHeight * screenHeight));
            double PPI = diagonalInPixels / diagonalInInches;
            double dotPitch = (diagonalInInches / diagonalInPixels) * 25.4;

            double result = Math.Round(diagonalInPixels);

            //returns calculated value
            if (screenHeight > 0 && screenWidth > 0 && diagonalInInches > 0)
            {
                return result.ToString();
            }
            else
            {
                return "Please provide inputs greater than zero";
            }
        }

        public static string PPICalculation(double screenWidth, double screenHeight, double diagonalInInches)
        {
            //performs diagonal in pixels, PPI, dot pitch calculation  
            double diagonalInPixels = Math.Sqrt((screenWidth * screenWidth) + (screenHeight * screenHeight));
            double PPI = diagonalInPixels / diagonalInInches;
            double dotPitch = (diagonalInInches / diagonalInPixels) * 25.4;

            double result = Math.Round(PPI, 2);
            //returns calculated value
            if (screenHeight > 0 && screenWidth > 0 && diagonalInInches > 0)
            {
                return result.ToString();
            }
            else
            {
                return "Please provide inputs greater than zero";
            }
        }

        public static string DotPitchCalculation(double screenWidth, double screenHeight, double diagonalInInches)
        {
            //performs diagonal in pixels, PPI, dot pitch calculation  
            double diagonalInPixels = Math.Sqrt((screenWidth * screenWidth) + (screenHeight * screenHeight));
            double PPI = diagonalInPixels / diagonalInInches;
            double dotPitch = (diagonalInInches / diagonalInPixels) * 25.4;

            double result = Math.Round(dotPitch, 4);

            //returns calculated value
            if (screenHeight > 0 && screenWidth > 0 && diagonalInInches > 0)
            {
                return result.ToString();
            }
            else
            {
                return "Please provide inputs greater than zero";
            }
        }
    }
}
