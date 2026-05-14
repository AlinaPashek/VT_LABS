// Manager.cs
using System;

namespace OOP_COLLECTIONS
{
    // =======================
    // Производный класс менеджера
    // =======================

    public class Manager : Employee
    {
        // =======================
        // Оценка работы от 0 до 10
        // =======================
        public int PerformanceScore { get; set; }

        public Manager(string name, double baseSalary, int performanceScore)
            : base(name, baseSalary)
        {
            PerformanceScore = performanceScore;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} has a score {PerformanceScore}");
        }

        public override double CalculateSalary()
        {
            double bonus = PerformanceScore * 200;
            return BaseSalary + bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"PerformanceScore: {PerformanceScore}");
        }
    }
}