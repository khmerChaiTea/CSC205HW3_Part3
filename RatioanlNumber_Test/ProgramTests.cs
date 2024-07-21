using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationalNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void WriteRationalTest()
        {
            // Arrange
            Rational rational = new Rational(1, 2);
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            string expected = $"Rational number: {rational}\r\n"; // Expected output including newline

            // Act
            Program.WriteRational(rational);
            string actual = sw.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}