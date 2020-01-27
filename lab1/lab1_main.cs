using System;
using System.Collections.Generic;

namespace Efimov
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				double a = 0, b = 0, c = 0;
				Console.WriteLine("Enter a, b and c: ");
				a = Convert.ToDouble(Console.ReadLine());
				b = Convert.ToDouble(Console.ReadLine());
				c = Convert.ToDouble(Console.ReadLine());
				MyLog.log(a + "X^2+" + b + "X+" + c + "=0");
				QuadraticEquation qe = new QuadraticEquation();
				List<double> list = qe.solve(a, b, c);
				String s = "Roots: ";
				foreach (double i in list) { s += i + " ";}
				MyLog.log(s);
			}
			catch (PersonalExсeption e)
			{
				MyLog.log("Error: " + e.Message);
			}
			MyLog.write();
			Console.ReadKey();
		}
	}
}


