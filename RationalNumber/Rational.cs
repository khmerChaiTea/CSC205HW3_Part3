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

        // Method to convert rational number to string representation
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        // Constructor to initialize the Rational object with numerator and denominator
        // Constructor: Takes two integers (numerator and denominator) and initializes the Rational object.
        // It simplifies the rational number by dividing both numerator and denominator by
        // their greatest common divisor (GCD), and ensures the denominator is always positive.
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
