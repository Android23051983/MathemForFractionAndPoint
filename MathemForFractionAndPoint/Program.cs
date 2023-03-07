// See https://aka.ms/new-console-template for more information
using static System.Console;
using MathemForFractionAndPoint;
Point point = new Point(10,5);
WriteLine($"Point: {point.ToString()}");
Point point1 = new Point(5,10);
Point point2 = new Point();
Fraction fraction = new Fraction(10, 5);
WriteLine($"Fraction1: {fraction.ToString()}");
Fraction fraction1 = new Fraction(10, 10);
WriteLine($"Fraction2: {fraction1.ToString()}");
var AddFraction = Fraction.Add(fraction, fraction1);
WriteLine($"Сложение: ({fraction}) + ({fraction1}) = {AddFraction}");
var MultiplyFraction = Fraction.Multiply(fraction, fraction1);
WriteLine($"Умножение:  ({fraction}) * ({fraction1}) = {MultiplyFraction}");
var SubtractFraction = Fraction.Subtract(fraction, fraction1);
WriteLine($"Вычитание: ({fraction}) - ({fraction1}) = {SubtractFraction}");
var DivideFraction = Fraction.Divide(fraction, fraction1);
WriteLine($"Деление: ({fraction}) / ({fraction1}) = {DivideFraction}");
