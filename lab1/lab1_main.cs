using System;
using System.Collections.Generic;

namespace lab1
{
	public class LinEquation {
		protected List<double> x;

		protected List<double> calcLinEquation(double a, double b) {
			List<double> t = new List<double>(); 

			if (a == 0 || b == 0) throw new Exception(":(");
			t.Add(b / a);
			return t;
		}
	}

	public class QuadEquation : LinEquation {
		public QuadEquation() {}

		protected double calcDiscriminant(double a, double b, double c) {			
			return (Math.Pow(b, 2) - 4 * a * c);
		}

		//ax^2 + bx + c = 0
		public List<double> calcQuadEquation(double a, double b, double c) {
			List<double> t = new List<double>();
			if (a == 0) {
				return (calcLinEquation(b, c));
			}

			double d = calcDiscriminant (a, b, c);
			if (d < 0) {
				throw new Exception(":(");
			}
			else if(d == 0) {
				t.Add (-b / (2 * a));
				return t;
			}

			else {
				t.Add(((-b + Math.Sqrt(d))/(2 * a)));
				t.Add(((-b - Math.Sqrt(d))/(2 * a)));
				return t;
			}
		}
	}

	public class Program {		
		static void Main() {
			QuadEquation exp = new QuadEquation ();
			List<double> result = new List<double>();

			try {
				result = exp.calcQuadEquation(0, 0, 0);
			}
			catch(Exception e) {
				Console.WriteLine (e.Message);
			}

			if (result.Count == 2)
				Console.WriteLine ("X1 = " + result [0] + ", X2 = " + result [1]);
			else if (result.Count == 1)
				Console.WriteLine ("X = " + result [0]);
		}
	}

}

