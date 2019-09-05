using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExercise_Hand_testing_class_Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TestMultiply
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Multiply_2_Positive()
        {
            Assert.That(uut.Multiply(4, 2), Is.EqualTo(8));
        }
        
        [Test]
        public void Multiply_2_Positive_Then_Use_Accumulator()
        {
            uut.Multiply(5, 5);
            Assert.That(uut.Multiply(4), Is.EqualTo(100));
        }

        [Test]
        public void Multiply_Negative_And_Positive()
        {
            Assert.That(uut.Multiply(4 , -15), Is.EqualTo(-60));
        }

        [Test]
        public void Multiply_by_zero_Equals_Zero()
        {
            Assert.That(uut.Multiply(123, 0), Is.Zero);
        }
    }



}