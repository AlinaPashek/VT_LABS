namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1.1
            Rational r1 = new Rational(3, 8);
            Console.WriteLine("Задание 1.1");
            Console.WriteLine(r1); // 3 / 8
            Console.WriteLine();

            // Задание 1.2
            Rational r2 = new Rational(4);
            Console.WriteLine("Задание 1.2");
            Console.WriteLine(r2); // 4
            Console.WriteLine();

            // Задание 1.3
            Rational r3 = new Rational();
            Console.WriteLine("Задание 1.3");
            Console.WriteLine(r3); // 0
            Console.WriteLine();

            // Задание 1.4
            Console.WriteLine("Задание 1.4");
            try
            {
                Rational r4 = new Rational(-3, 0);
                Console.WriteLine(r4);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.WriteLine();

            // Задание 2.1
            Rational r5 = new Rational(4, 8);
            Console.WriteLine("Задание 2.1");
            Console.WriteLine(r5); // 1 / 2
            Console.WriteLine();

            // Задание 2.2
            Rational r6 = new Rational(4, -9);
            Rational r7 = new Rational(-2, -10);
            Console.WriteLine("Задание 2.2");
            Console.WriteLine(r6); // -4 / 9
            Console.WriteLine(r7); // 1 / 5
            Console.WriteLine();

            // Задание 3.1
            Rational a = new Rational(1, 2);
            Rational b = new Rational(1, 3);
            Console.WriteLine("Задание 3.1");
            Console.WriteLine($"{a} + {b} = {a + b}"); // 5 / 6
            Console.WriteLine($"{a} - {b} = {a - b}"); // 1 / 6
            Console.WriteLine($"{a} * {b} = {a * b}"); // 1 / 6
            Console.WriteLine($"{a} / {b} = {a / b}"); // 3 / 2
            Console.WriteLine();

            // Задание 3.2
            Rational c = new Rational(2, 4);
            Rational d = new Rational(1, 2);
            Console.WriteLine("Задание 3.2");
            Console.WriteLine($"{c} == {d}: {c == d}"); // True
            Console.WriteLine($"{r1} != {d}: {r1 != d}"); // True
        }
    }
}