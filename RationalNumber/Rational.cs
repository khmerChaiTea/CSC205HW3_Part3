using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber
{
    public class Rational
    {
        // 1. Create a new program called Rational.cs that defines a class named Rational.
        // A Rational object should have two integer fields to store the numerator and denominator.

        // Fields to store numerator and denominator
        private int numerator;
        private int denominator;

        // 2. Write a default constructor, one that takes no arguments,
        // and that sets the numerator to 0 and denominator to 1.
        // Default constructor that initializes the rational number to 0/1
        public Rational()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        // Constructor to initialize the Rational object with numerator and denominator
        // Constructor: Takes two integers (numerator and denominator) and initializes the Rational object.
        // 6. Write a parametric constructor for your class that takes two arguments and that uses them to initialize the fields.
        // Parametric constructor that initializes the rational number with given numerator and denominator
        public Rational(int numerator, int denominator)
        {
            // Ensure denominator is not zero (validity check)
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            // Simplify the rational number by dividing numerator and denominator by their gcd
            // GCD Method: Uses Euclid's algorithm to calculate the greatest common divisor,
            // which helps simplify the rational number.
            // It simplifies the rational number by dividing both numerator and denominator by
            // their greatest common divisor (GCD), and ensures the denominator is always positive.
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;

            // Ensure the sign is always on the numerator
            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }

        }

        // Method to calculate the greatest common divisor (GCD) using Euclid's algorithm
        // Ex. GCD(2,3) => (temp = 3, b = 2 % 3 => 2, a = 3) which returned 3 as gcd
        // numerator become 2/3 and denominator become 3/3
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // 7. Write a method called Negate that reverses the sign of a rational number.
        // This method should be a modifier, so it should return void.
        // Add lines to Main to test the new method.
        // Method to negate the rational number (reverse its sign)
        public void Negate()
        {
            this.numerator = -this.numerator;
        }

        // 8. Write a method called Invert that inverts the number by swapping the
        // numerator and denominator. Add lines to Main to test the new method.
        // Method to invert the rational number (swap numerator and denominator)
        public void Invert()
        {
            int temp = this.numerator;
            this.numerator = this.denominator;
            this.denominator = temp;

            // Ensure the sign is always on the numerator after inversion
            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }
        }

        // 9. Write a method called ToDouble that converts the rational number
        // to a double(floating-point number) and returns the result. This method
        // is a pure function; it does not modify the object. As always, test the new method.
        // Method to convert the rational number to a double
        public double ToDouble()
        {
            return (double)this.numerator / this.denominator;
        }

        // Override ToString() to convert rational number to string representation
        public override string ToString()
        {
            // Display the rational number in numerator/denominator format
            return $"{numerator}/{denominator}";
        }

        //// Method to add two rational numbers
        //public Rational Add(Rational other)
        //{
        //    int num = this.numerator * other.denominator + other.numerator * this.denominator;
        //    int denom = this.denominator * other.denominator;
        //    return new Rational(num, denom);
        //}

        //// Method to multiply two rational numbers
        //public Rational Multiply(Rational other)
        //{
        //    int num = this.numerator * other.numerator;
        //    int denom = this.denominator * other.denominator;
        //    return new Rational(num, denom);
        //}
    }
}
