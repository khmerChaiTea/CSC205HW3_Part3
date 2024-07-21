using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(); // Using the default constructor

            Rational sum = r1.Add(r2);
            Rational product = r1.Multiply(r2);

            Console.WriteLine($"r1 = {r1}");
            Console.WriteLine($"r2 = {r2}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Product = {product}");
        }
    }
}
