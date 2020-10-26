using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        private IFileReader fileReader = new FileReader();

        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1, num2);
                    break;
                case "t":
                    result = Triangle(num1, num2);
                    break;
                case "c":
                    result = Circle(num1, num2);
                    break;
                case "i":
                    result = CFI(num1, num2, 100);
                    break;
                case "e":
                    result = AEF(num1, num2, 100);
                    break;
                case "z":
                    result = GenMagicNum(num1,fileReader);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }

        public virtual double GenMagicNum(double a, Mock<IFileReader> mockFileReader)
        {
            mockFileReader = new Mock<IFileReader>();
            mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            double result = GenMagicNum(a, fileReader);
            return result;
        }

        public double Add(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 666;
            }
            else if (num1 == 0)
            {
                num2 = num2 / 10;
                return num2;
            }
            else if(num2 == 0)
            {
                num1 = num1 * 10;
                return num1;
            }
            else
            {
                return (num1 + num2);
            }
            
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {

            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            else if (num1 == 0)
            {
                return 0;
            }
            else if (num2 == 0)
            {
                return double.PositiveInfinity;
            }
            else if (num1 == 0 || num2 == 0)
            {
                throw new ArgumentException("You can't divide by Zero!");
            }
            else
            {
                return (num1 / num2);
            }
            
        }
        public double Factorial(double num1, double num2)
        {
            if (num1 < 0)
            {
                throw new ArgumentException("Enter a value of 0 or more");
                
            }
            else if(num1 == 0)
            {
                return 1;
            }
            else
            {
                double factorial = 1.0;
                for (double counter = 1.0; counter <= num1; counter++)
                {
                    factorial = factorial * counter;
                }
                return factorial;
            }
        }
        public double Triangle(double num1, double num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                throw new ArgumentException("You can't divide by Zero!");
            }
            else if (num1 < 0 || num2 < 0)
            {
                throw new ArgumentException("You can't have a negative area!");
            }
            else
            {
                return (0.5 * num1 * num2);
            }
        }
        public double Circle(double num1, double num2)
        {
            if (num1 == 0)
            {
                throw new ArgumentException("You can't divide by Zero!");
            }
            else if (num1 < 0)
            {
                throw new ArgumentException("You can't have a negative area!");
            }
            else
            {
                // Assuming pi is 3.14 in this case
                return (3.14 * num1 * num1);
            }
        }
        /*
         * Calculate Current Failure Intensity
         * Calculate Average Expected Failure Rate
         * */
        public double CFI(double num1, double num2,double assume)
        {
            return (num1 * (1 - (num2 / assume)));
        }
        public double AEF(double num1, double num2, double assume)
        {
            return Math.Round((assume * (1- Math.Exp(-(num1/assume)*num2))));
        }
        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            string path = "C:/Users/faiz_/source/repos/ICT3101_Calculator/MagicNumbers.txt";
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------
            //FileReader getTheMagic = new FileReader();
            //----------------------------------------
            string[] magicStrings = fileReader.Read(path);
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}
