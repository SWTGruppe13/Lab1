using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise_Hand_testing_class_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator cal = new Calculator();

			Console.WriteLine($"2 + 2 er {cal.Add(2,2)}");
			Console.WriteLine($"5 - 2 er {cal.Subtract(5, 2)}");
			Console.WriteLine($"4 * 2 er {cal.Multiply(4, 2)}");
			Console.WriteLine($"2^4 er {cal.Power(2, 4)}");

			if (cal.Add(2, 2) == 4)
			{
				Console.WriteLine("2 + 2 er 4, derved virker Add");
			}
			else
			{
				Console.WriteLine($"Add virker ikke, og gav værdien: {cal.Add(2,2)}");
			}

			if (cal.Subtract(5, 2) == 3)
			{
				Console.WriteLine("5 - 2 er 3, derved virker Subtract");
			}
			else
			{
				Console.WriteLine($"Subtract virker ikke, og gav værdien: {cal.Subtract(5, 2)}");
			}

			if (cal.Multiply(4, 2) == 8)
			{
				Console.WriteLine("4 * 2 er 8, derved virker Multiply");
			}
			else
			{
				Console.WriteLine($"Multiply virker ikke, og gav værdien: {cal.Multiply(4, 2)}");
			}

			if (cal.Power(2, 4) == 16)
			{
				Console.WriteLine(" 2^4 er 16, derved virker Power");
			}
			else
			{
				Console.WriteLine($"Power virker ikke, og gav værdien: {cal.Power(2, 4)}");
			}

		}
	}
}
