using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathemForFractionAndPoint {
    internal class Fraction : IMathem {
        long m_iNumerator;
        long m_iDenominator;

        public Fraction() { Initialize(0, 1); }


        private void Initialize(long iNumerator, long iDenominator) {
            Numerator = iNumerator;
            Denominator = iDenominator;
            ReduceFraction(this);
        }

        private static long GCD(long iNo1, long iNo2) {
            // take absolute values
            if (iNo1 < 0) iNo1 = -iNo1;
            if (iNo2 < 0) iNo2 = -iNo2;

            do {
                if (iNo1 < iNo2) {
                    long tmp = iNo1;
                    iNo1 = iNo2;
                    iNo2 = tmp;
                }
                iNo1 = iNo1 % iNo2;
            } while (iNo1 != 0);
            return iNo2;
        }

        public static void ReduceFraction(Fraction frac) {
            try {
                if (frac.Numerator == 0) {
                    frac.Denominator = 1;
                    return;
                }

                long iGCD = GCD(frac.Numerator, frac.Denominator);
                frac.Numerator /= iGCD;
                frac.Denominator /= iGCD;

                if (frac.Denominator < 0) {
                    frac.Numerator *= -1;
                    frac.Denominator *= -1;
                }
            }
            catch (Exception exp) {
                throw new FractionException("Cannot reduce Fraction: " + exp.Message);
            }
        }

        public long Denominator {
            get { return m_iDenominator; }
            set {
                if (value != 0)
                    m_iDenominator = value;
                else
                    throw new FractionException("Denominator cannot be assigned a ZERO Value");
            }
        }

        public long Numerator {
            get { return m_iNumerator; }
            set { m_iNumerator = value; }
        }
    }
    public class FractionException : Exception {
        public FractionException() : base() { }

        public FractionException(string Message) : base(Message) { }

        public FractionException(string Message, Exception InnerException) : base(Message, InnerException) { }
    }
}
