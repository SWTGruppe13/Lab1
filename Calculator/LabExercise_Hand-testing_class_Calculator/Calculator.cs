using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise_Hand_testing_class_Calculator
{
	public class Calculator
	{
		public double Add(double a, double b)
		{
			return a + b;
		}

		public double Subtract(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			return a * b;
		}

		public double Power(double x, double exp)
		{
			return Math.Pow(x, exp);
		}

		public double Divide(double dividend, double divisor)
		{
			if (dividend != 0 || divisor != divisor)
				return dividend / divisor;
			else
			{
				throw new Exception("You tried to devide by 0, stop that or ill delete you're WOW acc!");
			}
		}
		

	}
}
