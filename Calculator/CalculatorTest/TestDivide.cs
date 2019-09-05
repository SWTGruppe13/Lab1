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
        public void DivideByZero_Two_DevidedBy_Zero()
        {
            Assert.Throws<ArgumentException>(() => uut.Divide(2, 0));
        }

    }
}