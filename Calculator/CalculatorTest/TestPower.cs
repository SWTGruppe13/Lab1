using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExercise_Hand_testing_class_Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TestPower
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(4,2,16)]      // Simple test
        [TestCase(0.5,3,0.125)] // Decimal number as base
        [TestCase(4,2.5,32)]    // Decimal number as exponent
        [TestCase(1,-2,1)]      // Negative exponent resulting in whole number
        [TestCase(5,-3,0.008)]  // Negative exponent resulting in decimal number
        [TestCase(-5,3,-125)]   // Negative base
        [TestCase(0.5,-3,8)]    // Decimal base with negative exponent
        [TestCase(5,0,1)]       // 0 as exponent
        [TestCase(0,10,0)]      // 0 as base
        [TestCase(1,10,1)]      // 1 as base
        public void PowerOfTwoNumbers(double x, double exp, double result)
        {
            Assert.That(uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(4, 2, 2, 256)]        // Positive integer as accumulator base
        [TestCase(0.5, 2, 2, 0.0625)]   // Decimal number as accumulator base
        [TestCase(-3, 3, 3, -19683)]    // Negative integer as accumulator base
        public void PowerOfTwoNumbersUsingAccumulator(double x, double exp1, double exp2, double  result)
        {
            uut.Power(x, exp1);
            Assert.That(uut.Power(exp2), Is.EqualTo(result));
        }
    }

}