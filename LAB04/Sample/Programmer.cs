//Programmers.cs
using System;

namespace OOP_COLLECTIONS
{
    // =======================
    // Производный класс программиста
    // =======================

    public class Programmer : Employee
    {
        // =======================
        // Уровень программиста: Junior, Middle, Senior, Lead
        // =======================
        public string Level { get; set; }

        public Programmer(string name, double baseSalary, string level)
            : base(name, baseSalary)
        {
            Level = level;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working as a {Level} developer.");
        }

        public override double CalculateSalary()
        {
            double bonus = 0;

            switch (Level)
            {
                case "Junior":
                    bonus = 300;
                    break;

                case "Middle":
                    bonus = 600;
                    break;

                case "Senior":
                    bonus = 1000;
                    break;

                case "Lead":
                    bonus = 1500;
                    break;

                default:
                    bonus = 0;
                    break;
            }

            return BaseSalary + bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Level: {Level}");
        }
    }
}