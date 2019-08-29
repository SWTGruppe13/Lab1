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
		public void AddTwoNumbers_Four_Plus_Two_ReturnSix()
		{
			Assert.That(uut.Add(4,2),Is.EqualTo(6));
		}

		[Test]
		public void MultiplyTwoNumbers_Four_Times_Two_ReturnEigth()
		{
			Assert.That(uut.Multiply(4, 2), Is.EqualTo(8));
		}

		[Test]
		public void SubtractTwoNumbers_Four_Minus_Two_ReturnTwo()
		{
			Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));
		}

		[Test]
		public void PowerOfTwoNumbers_Four_ToThePowerOf_Two_Return16()
		{
			Assert.That(uut.Power(4, 2), Is.EqualTo(16));
		}

		[Test]
		public void DivideByZero_Zero_DevidedBy_Two()
		{

		}
	}
}
