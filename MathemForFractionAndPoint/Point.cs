using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

namespace MathemForFractionAndPoint {
    internal class Point : IMathem {
        double x;
        double y;

        public double X {
            set { x = value; }
            get { return x; }
        }

        public double Y {
            set { y = value; }
            get { return y; }
        }

        public Point(double x = 0, double y = 0) {
            this.x = x;
            this.y = y;
            WriteLine($"Constructor:\t\t{this}");
        }

        public Point(Point other) {
            this.x = other.x;
            this.y = other.y;
            WriteLine($"CopyConstructor:\t{this}");
        }

       public double distance(Point other){
		double x_distance = this.x - other.x;
        double y_distance = this.y - other.y;
        //sqrt - Square Root (Квадратный коринь)
        double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
		return distance;
	   }

        public override string ToString() => $"X = {x}\tY = {y}";
    }
}
