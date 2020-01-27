using System;
using System.Collections.Generic;

namespace Efimov
{
	class LinearEquation
    {
        protected List<double> roots = new List<double>();


        public List<double> Roots {
            get { return roots; }
            set { roots = value; }
        }
        public List<double> linearEquation(double a, double b) {
            if (a == 0) {
                throw new PersonalExсeption("There is no such equation");
            }
            Roots.Add((double)-b / a);
            MyLog.log("Linear equation detected");
            return roots;
        }
    }
}
