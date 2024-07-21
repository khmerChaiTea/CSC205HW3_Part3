﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber
{
    public class Program
    {
        // 3. Write a method called WriteRational that takes a Rational object
        // as an argument and outputs it in some reasonable format.
        // Method to write the Rational object to console in a reasonable format
        public static void WriteRational(Rational rational)
        {
            Console.WriteLine($"Rational number: {rational}");
        }

        // 4. Write a Main method that creates a new object with type Rational,
        // sets its fields to some values, and writes the object.
        // Main method to demonstrate usage
        public static void Main(string[] args)
        {
            // Testing the default constructor
            Rational defaultRational = new Rational();
            Console.WriteLine("Default Rational: " + defaultRational);

            // Testing the parameterized constructor
            Rational rationalNumber = new Rational(2, 3);  // Example: 2/3
            Console.WriteLine("Rational Number: " + rationalNumber);
            Console.WriteLine("Rational Number as Double: " + rationalNumber.ToDouble());

            // Test Negate method
            rationalNumber.Negate();
            Console.WriteLine("Negated Rational Number: " + rationalNumber);

            // Test Invert method
            rationalNumber.Invert();
            Console.WriteLine("Inverted Rational Number: " + rationalNumber);

            Rational piApproximation = new Rational(355, 113);  // Example: 355/113 as an approximation of Pi
            Console.WriteLine("Pi Approximation: " + piApproximation);
            Console.WriteLine("Pi Approximation as Double: " + piApproximation.ToDouble());

            // Test Invert method
            piApproximation.Invert();
            Console.WriteLine("Inverted Pi Approximation: " + piApproximation);

            Rational wholeNumber = new Rational(7, 1);  // Example: 7 (implicitly 7/1)
            Console.WriteLine("Whole Number: " + wholeNumber);
            Console.WriteLine("Whole Number as Double: " + wholeNumber.ToDouble());

            // Test Invert method
            wholeNumber.Invert();
            Console.WriteLine("Inverted Whole Number: " + wholeNumber);
        }

    }
}
