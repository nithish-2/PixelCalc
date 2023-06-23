using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelCalc
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //declaring necessary variables required for the application
            double screenWidth = 0, screenHeight = 0, diagonalInInches = 0, diagonalInPixels = 0, PPI = 0, dotPitch = 0;
            bool mainMenu = true;

            //clearing the console
            Console.Clear();

            //displaying menu options
            while (mainMenu)
            {
                Console.WriteLine("********************************************************************");
                Console.WriteLine("1. Enter Screen dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine("********************************************************************");
                string mainMenuOption = Console.ReadLine();

                //receives screen width, screen height, diagonal input from user if menu option 1 is selected
                if (mainMenuOption == "1")
                {
                    //receives screen width from user and validates if it is double or not
                    bool enterScreenWidth = true;
                    while (enterScreenWidth)
                    {
                        Console.WriteLine("Enter Screen Width (in pixels):");
                        String screenWidthString = Console.ReadLine();
                        if (Double.TryParse(screenWidthString, out screenWidth))
                        {
                            enterScreenWidth = false;
                        }
                        else
                        {
                            enterScreenWidth = true;
                        }
                    }

                    //receives screen height from user and validates if it is double or not
                    bool enterScreenHeight = true;
                    while (enterScreenHeight)
                    {
                        Console.WriteLine("Enter Screen Height (in pixels):");
                        String screenHeightString = Console.ReadLine();
                        if (Double.TryParse(screenHeightString, out screenHeight))
                        {
                            enterScreenHeight = false;
                        }
                        else
                        {
                            enterScreenHeight = true;
                        }
                    }

                    //receives diagoanal in inches from user and validates if it is double or not
                    bool enterDiagonalInInches = true;
                    while (enterDiagonalInInches)
                    {
                        Console.WriteLine("Enter Diagonal Size (in inches):");
                        String diagonalInInchesString = Console.ReadLine();
                        if (Double.TryParse(diagonalInInchesString, out diagonalInInches))
                        {
                            enterDiagonalInInches = false;
                        }
                        else
                        {
                            enterDiagonalInInches = true;
                        }
                    }

                    Console.WriteLine(PixelCalc.DiagonalInPixelCalculation(screenWidth, screenHeight, diagonalInInches));
                    Console.WriteLine(PixelCalc.PPICalculation(screenWidth, screenHeight, diagonalInInches));
                    Console.WriteLine(PixelCalc.DotPitchCalculation(screenWidth, screenHeight, diagonalInInches));

                }

                //exits program if menu option 2 is selected
                if (mainMenuOption == "2")
                {
                    Console.Clear();
                    Console.WriteLine("********************************");
                    Console.WriteLine("Thank You!");
                    Console.WriteLine("********************************");
                    System.Environment.Exit(1);
                }
            }

        }

    }
}
