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
            Accumulator = a + b;
			return a + b;
		}
        public double Accumulator { get; private set; }

        public double Add(double addend)
        {
            return Accumulator += addend;
        }

		public double Subtract(double a, double b)
		{
            Accumulator = a - b;
			return a - b;
		}

        public double Subtract(double subtractor)
        {
            return Accumulator -= subtractor;
        }

		public double Multiply(double a, double b)
		{
            Accumulator = a * b;
			return a * b;
		}

        public double Multiply(double multiplier)
        {
            return Accumulator *= multiplier;
        }

		public double Power(double x, double exp)
		{
            Accumulator = Math.Pow(x, exp);
			return Math.Pow(x, exp);
		}

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
		public double Divide(double dividend, double divisor)
		{
            if (divisor != 0)
            {
                Accumulator = dividend / divisor;
                return dividend / divisor;
            }
            else
            {
                throw new ArgumentException("You tried to devide by 0, stop that or ill delete your WOW acc!");
            }
		}

        public double Divide(double divisor)
        {
            if (divisor != 0)
                return Accumulator/=divisor;
            else
            {
                throw new ArgumentException("You tried to devide by 0, stop that or ill delete you're WOW acc!");
            }
        }
	}
}
