using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài12
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Mẫu số không thể bằng 0.");

            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        public Fraction Add(Fraction other)
        {
            int numerator = Numerator * other.Denominator + other.Numerator * Denominator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Subtract(Fraction other)
        {
            int numerator = Numerator * other.Denominator - other.Numerator * Denominator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Multiply(Fraction other)
        {
            int numerator = Numerator * other.Numerator;
            int denominator = Denominator * other.Denominator;
            return new Fraction(numerator, denominator);
        }

        public Fraction Divide(Fraction other)
        {
            if (other.Numerator == 0)
                throw new DivideByZeroException("Không thể chia cho phân số có tử số bằng 0.");

            int numerator = Numerator * other.Denominator;
            int denominator = Denominator * other.Numerator;
            return new Fraction(numerator, denominator);
        }

        private void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
