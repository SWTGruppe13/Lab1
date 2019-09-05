using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExercise_Hand_testing_class_Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class Class1
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void MultiplyTwoNumbers_Four_Times_Two_ReturnEigth()
        {
            Assert.That(uut.Multiply(4, 2), Is.EqualTo(8));
        }



    }

}