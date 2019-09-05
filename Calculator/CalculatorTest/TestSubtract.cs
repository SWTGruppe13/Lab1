using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExercise_Hand_testing_class_Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TestSubstract
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(5,5,0)]
        [TestCase(-2,-2,0)]
        [TestCase(5.5,5.5,0)]
        public void Subtract_Equals_Zero(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(0, 5, -5)]
        [TestCase(2, 3, -1)]
        [TestCase(5, 5.5, -0.5)]
        public void Subtract_Equals_Negative_Result(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(0, -5, 5)]
        [TestCase(2, -3, 5)]
        [TestCase(-2, -2, 0)]
        [TestCase(5, -5.5, 10.5)]
        public void Subtract_Negative_Number_Equals_Addition(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(-2, -5, 3)]
        [TestCase(-3, -3, 0)]
        [TestCase(-5, -1, -4)]
        [TestCase(-5, -5.5, 0.5)]
        public void Subtract_Two_Negative_Numbers(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(c));
        }
    }
}