using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExercise_Hand_testing_class_Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TestDivide
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(4, 2, 2)]
        [TestCase(10, 2, 5)]
        [TestCase(-5, 2, -2.5)]
        [TestCase(9.9,3,3.3)]
        public void Divide_Test_Simpel_Decimal_Negativ(double a, double b, double c)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(c).Within(0.03));
        }

        [Test]
        public void DivideByZero_Two_DevidedBy_Zero()
        {
            Assert.Throws<ArgumentException>(() => uut.Divide(2, 0));
        }

    }
}