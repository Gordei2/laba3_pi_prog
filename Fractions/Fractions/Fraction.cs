namespace Fractions
{
    public class Fraction
    {
        public long num { get; set; }
        public uint den { get; set; }

        public Fraction(long numerator, uint denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            num = numerator;
            den = denominator;
        }

        public static Fraction operator +(Fraction frac) => frac;
        public static Fraction operator -(Fraction frac) => new Fraction(-frac.num, frac.den);

        public static Fraction operator +(Fraction left, Fraction right)
            => new Fraction(left.num * right.den + right.num * left.den, left.den * right.den).simplify();

        public static Fraction operator -(Fraction left, Fraction right) 
            => new Fraction(left.num * right.den - right.num * left.den, left.den * right.den).simplify();

        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.num * b.num, a.den * b.den);

        public static Fraction operator *(Fraction a, long number) => new Fraction(a.num * number, a.den);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
                throw new DivideByZeroException();

            var n = a.num * b.den;
            var d = a.den * b.num;

            return (n >= 0 && d < 0 || n < 0 && d > 0) ?
                new Fraction(-Math.Abs(n), (uint)Math.Abs(d)) :
                new Fraction(Math.Abs(n), (uint)Math.Abs(d));
        }

        public Fraction simplify()
        {
            long nod = gcd(num, den);

            return new Fraction(num / nod, (uint)(den / nod));
        }

        private long gcd(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a | b;
        }

        public static bool operator ==(Fraction left, Fraction right) => 
            left is null && right is null || left.num == right.num && left.den == right.den;

        public static bool operator !=(Fraction left, Fraction right) => !(left == right);

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Fraction))
                return false;

            return ((Fraction)obj).num == this.num && ((Fraction)obj).den == this.den;
        }

        public override int GetHashCode() => num.GetHashCode() + den.GetHashCode();

        public override string ToString() => $"{num} / {den}";
    }
}