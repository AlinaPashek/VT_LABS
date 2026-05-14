//Worker.cs
using System;

namespace OOP_COLLECTIONS
{
    // =======================
    // Производный класс рабочего
    // =======================

    public class Worker : Employee
    {
        // =======================
        // Для каждого рабочего характерно число смен в месяц
        // =======================
        public int MonthlyShifts { get; set; }

        public Worker(string name, double baseSalary, int monthlyShifts)
            : base(name, baseSalary)
        {
            MonthlyShifts = monthlyShifts;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is doing shift-based work.");
        }

        public override double CalculateSalary()
        {
            int minimumShifts = 20;
            double bonusPerExtraShift = 50;
            double bonus = 0;

            if (MonthlyShifts > minimumShifts)
            {
                bonus = (MonthlyShifts - minimumShifts) * bonusPerExtraShift;
            }

            return BaseSalary + bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Monthly Shifts: {MonthlyShifts}");
        }
    }
}