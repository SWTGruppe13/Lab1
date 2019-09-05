using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExercise_Hand_testing_class_Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TestSubtract
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void SubtractTwoNumbers_Four_Minus_Two_ReturnTwo()
        {
            Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));
        }



    }

}