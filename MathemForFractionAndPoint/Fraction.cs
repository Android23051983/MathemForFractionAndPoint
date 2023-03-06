using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathemForFractionAndPoint {
    internal class Fraction : IMathem {
        uint chislitel, znamenatel;
        public Fraction(uint chislitel, uint znamenatel) {
            SetChis(chislitel);
            SetZnam(znamenatel);
        }
        public Fraction() { }
        public uint Number1 {
            set { chislitel = value; } get { return chislitel; } }   
        public void SetChis(uint chislitel) { this.chislitel = chislitel; }
        public void SetZnam(uint znamenatel) { this.znamenatel = znamenatel; }
        public uint GetChis() { return chislitel; }
        public uint GetZnam() { return znamenatel; }
        public static uint Nod(uint a, uint b) {
            if (b == 0)
                return a;
            return Nod(b, a % b);
        }
        public static Fraction Sokr(Fraction f) {
            uint nod = Nod(f.chislitel, f.znamenatel);
            f.chislitel /= nod;
            f.znamenatel /= nod;
            return f;
        }
        public static object Multiply(object a, uint n) {
            var other = a as Fraction;
            Fraction f = new Fraction(other.GetChis() * n, other.GetZnam());
            if (f) return f;
            else Sokr(f);
            return f;
        }
        public static object Multiply(uint n, object a) {
            return Multiply(a , n);
        }

        public static object Multiply(object a, object b) {
            var other1 = a as Fraction;
            var other2 = b as Fraction;
            Fraction f = new Fraction(other1.GetChis() * other2.GetChis(), other1.GetZnam() * other2.GetZnam());
            if (f) return f;
            else Sokr(f);
            return f;
        }

        public static Boolean operator true(Fraction f) {
            return (f.chislitel < f.znamenatel);
        }
        public static Boolean operator false(Fraction f) {
            return (f.chislitel > f.znamenatel);
        }
        public static object Add(object a, object b) {
            var other1 = a as Fraction;
            var other2 = b as Fraction;
            Fraction f = new Fraction(other1.GetChis() * other2.GetZnam() + other2.GetChis() * other1.GetZnam(), other1.GetZnam() * other2.GetZnam());
            if (f) return f;
            else Sokr(f);
            return f;
        }
        public static object Add(object a, double d) {
            var other = a as Fraction;
            uint znam = 1;
            while (d > (uint)d) {
                d *= 10;
                znam *= 10;
            }

            Fraction f = new Fraction((uint)d, znam);
            return Add(other, f);
        }
        public override string ToString() => $"{chislitel} / {znamenatel}" ;
    }
}
