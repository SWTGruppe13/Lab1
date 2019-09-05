using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabExercise_Hand_testing_class_Calculator;
using NUnit.Framework;
using NUnit.Framework.Internal;

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

        [TestCase(1, 1, 2)]
		[TestCase(5, 5, 10)]
		[TestCase(-1, 10, 9)]
		[TestCase(5, -5, 0)]
		[TestCase(4.5, 5.5, 10)]
		[TestCase(7.3, 7.4, 14.7)]
		[TestCase(-2.2, -4.2, -6.4)]
        public void AddTwoNumbers_Simpel_NegativNumber_Decimal(Double a, Double b, Double c)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(c));
        }

        [Test] 
        public void AddTwoNumbers_Accumulator_Five_Plus_Five_Plus_7_Is_Seventeen()
        {
            uut.Add(5+5);
            Assert.That(uut.Add(7), Is.EqualTo(17));
        }
    }

}