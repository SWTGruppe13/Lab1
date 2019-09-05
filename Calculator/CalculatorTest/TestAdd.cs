using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExercise_Hand_testing_class_Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class TestAdd
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void AddTwoNumbers_Four_Plus_Two_ReturnSix()
        {
            Assert.That(uut.Add(4, 2), Is.EqualTo(6));
        }

    }

}