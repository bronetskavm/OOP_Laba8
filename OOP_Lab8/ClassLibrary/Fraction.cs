using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    // Клас Fraction (натуральні дроби)
    public class Fraction
    {
        private int numerator; // чисельник
        private int denominator; // знаменник

        // Конструктор з параметрами
        public Fraction(int num, int denom)
        {
            numerator = num;
            if (denom != 0)
                denominator = denom;
            else
                throw new ArgumentException("Знаменник не може дорівнювати нулю.");
        }

        // Конструктор за замовчуванням
        public Fraction() : this(0, 1)
        {
        }

        // Конструктор копіювання
        public Fraction(Fraction frac)
        {
            numerator = frac.numerator;
            denominator = frac.denominator;
        }

        // Метод для скорочення дробу
        public void Simplify()
        {
            int gcd = GreatestCommonDivisor(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        // Перевантаження операцій арифметики для дробів
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.numerator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2.numerator != 0)
            {
                int num = f1.numerator * f2.denominator;
                int denom = f1.denominator * f2.numerator;
                return new Fraction(num, denom);
            }
            else
                throw new DivideByZeroException("Не можна ділити на нуль.");
        }

        // Перевантаження операцій порівняння для дробів
        public static bool operator >(Fraction f1, Fraction f2)
        {
            return (double)f1 > (double)f2;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return (double)f1 < (double)f2;
        }

        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return (double)f1 >= (double)f2;
        }

        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return (double)f1 <= (double)f2;
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.Equals(f2);
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !f1.Equals(f2);
        }

        // Перевизначений метод ToString()
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        // Операція приведення типу до double (десяткового дробу)
        public static explicit operator double(Fraction f)
        {
            return (double)f.numerator / f.denominator;
        }

        // Метод знаходження найбільшого спільного дільника
        private int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
