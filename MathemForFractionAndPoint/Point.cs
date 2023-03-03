using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

namespace MathemForFractionAndPoint {
    internal class Point : object, IMathem {
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
            //WriteLine($"Constructor:\t\t{this}");
        }

        public Point(Point other) {
            this.x = other.x;
            this.y = other.y;
            // WriteLine($"CopyConstructor:\t{this}");
        }

        public double distance(Point other) {
            double x_distance = this.x - other.x;
            double y_distance = this.y - other.y;
            //sqrt - Square Root (Квадратный коринь)
            double distance = Math.Sqrt(x_distance * x_distance + y_distance * y_distance);
            return distance;
        }

        public static Point Add(Point obj1, Point obj2) {
        
            double iX = obj1.X + obj2.X;
            double iY = obj1.Y + obj2.Y;
            return new Point(iX, iY);
        }



        public override string ToString() => $"X = {x} Y = {y}";

        public object Add(object obj, object obj2) {
            throw new NotImplementedException();
        }

        public object Subtract(object obj, object obj2) {
            throw new NotImplementedException();
        }

        public object Multiply(object obj, object obj2) {
            throw new NotImplementedException();
        }

        public object Divide(object obj, object obj2) {
            throw new NotImplementedException();
        }
    }
}
