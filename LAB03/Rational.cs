using System;

namespace LAB03
{
    public class Rational
    {
        // Поля (Числитель и Знаменатель)
        private int numerator;
        private int denominator;

        // Свойства (Доступ к Полям)
        public int Numerator
        {
            get => numerator;
            set => numerator = value;
        }

        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                denominator = value;
            }
        }

        // Конструкторы
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");

            this.numerator = numerator;
            this.denominator = denominator;

            // Сокращаем дробь в момент создания
            Reduce();

            // Нормализуем знак дроби
            Normalize();
        }

        public Rational(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public Rational()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        // ToString
        public override string ToString()
        {
            // Если знаменатель равен 1, выводим только числитель
            if (this.denominator == 1)
                return this.numerator.ToString();

            // Иначе выводим дробь в виде numerator / denominator
            return $"{this.numerator} / {this.denominator}";
        }

        // Метод нормализации знака дроби
        private void Normalize()
        {
            // Если знаменатель отрицательный, переносим минус в числитель
            if (this.denominator < 0)
            {
                this.numerator *= -1;
                this.denominator *= -1;
            }
        }

        // НОД (алгоритм Евклида). Нужен для сокращения дроби
        private static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // Сокращение дроби (делим числитель и знаменатель на НОД)
        public void Reduce()
        {
            int gcd = GCD(this.numerator, this.denominator);
            this.numerator /= gcd;
            this.denominator /= gcd;
        }

        // Перегрузка операторов

        /* 
           Метод суммы (Суммой двух дробей (a и b) является новая Дробь)
           С числителем и знаменателем, рассчитанным по формуле:
        */
        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.denominator + b.numerator * a.denominator,
                a.denominator * b.denominator
            );
        }

        // Метод разности двух дробей
        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.denominator - b.numerator * a.denominator,
                a.denominator * b.denominator
            );
        }

        // Метод произведения двух дробей
        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.numerator,
                a.denominator * b.denominator
            );
        }

        // Метод деления двух дробей
        public static Rational operator /(Rational a, Rational b)
        {
            if (b.numerator == 0)
                throw new DivideByZeroException("Деление на ноль");

            return new Rational(
                a.numerator * b.denominator,
                a.denominator * b.numerator
            );
        }

        // Сравнение
        public static bool operator ==(Rational a, Rational b)
        {
            // Если обе ссылки указывают на один объект
            if (ReferenceEquals(a, b))
                return true;

            // Если один из объектов равен null
            if (a is null || b is null)
                return false;

            // Дроби равны, если равны их числители и знаменатели
            return a.numerator == b.numerator && a.denominator == b.denominator;
        }

        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rational other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
    }
}