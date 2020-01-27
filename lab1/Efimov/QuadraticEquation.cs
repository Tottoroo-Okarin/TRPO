using System;
using System.Collections.Generic;

namespace Efimov
{
	class QuadraticEquation : LinearEquation, core.EquationInterface
    {
        protected double discriminant(double a, double b, double c) {
            return b * b - 4 * a * c;
        }
        public List<double> solve(double a, double b, double c) {
            if (a == 0)
                return linearEquation(b, c);
			
            double d = this.discriminant(a, b, c);

            if (d == 0)
                Roots.Add((-b + Math.Sqrt(d)) / 2 * a);
            else if (d > 0) {
                Roots.Add((-b + Math.Sqrt(d)) / 2 * a);
                Roots.Add((-b - Math.Sqrt(d)) / 2 * a);
            }
            else throw new PersonalExсeption("There are no roots");
            MyLog.log("Quadratic equation detected");
            return roots;
        }
    }
}
