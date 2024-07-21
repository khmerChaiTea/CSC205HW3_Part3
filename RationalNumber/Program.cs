using System;
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
            // Example usage of Rational class and WriteRational method
            Rational rational1 = new Rational(1, 2);
            Rational rational2 = new Rational(3, 4);

            WriteRational(rational1);
            WriteRational(rational2);
        }

    }
}
