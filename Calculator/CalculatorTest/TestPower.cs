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

        [Test]
        public void PowerOfTwoNumbers_Four_ToThePowerOf_Two_Return16()
        {
            Assert.That(uut.Power(4, 2), Is.EqualTo(16));
        }
    }

}