using System;
using System.Collections.Generic;

namespace OOP_COLLECTIONS
{
    // =======================
    // Класс отдела
    // =======================

    public class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; private set; }

        public Department(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }

        // =========================
        // Добавление сотрудника в отдел
        // Нельзя добавить больше одного менеджера
        // =========================
        public void AddEmployee(Employee employee)
        {
            if (employee is Manager)
            {
                foreach (Employee emp in Employees)
                {
                    if (emp is Manager)
                    {
                        Console.WriteLine("Cannot add more than one manager to the department.");
                        return;
                    }
                }
            }

            Employees.Add(employee);
        }

        // =========================
        // Поиск сотрудника по Id
        // =========================
        public Employee? FindEmployeeById(int id)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }

            return null;
        }

        // =========================
        // Удаление сотрудника по Id
        // =========================
        public bool RemoveEmployeeById(int id)
        {
            Employee? emp = FindEmployeeById(id);

            if (emp != null)
            {
                Employees.Remove(emp);
                return true;
            }

            return false;
        }

        // =========================
        // Вывод всех сотрудников отдела
        // =========================
        public void ShowAllEmployees()
        {
            Console.WriteLine($"\nDepartment: {Name}");

            foreach (Employee emp in Employees)
            {
                emp.DisplayInfo();
                emp.Work();
                Console.WriteLine($"Total Salary: {emp.CalculateSalary()}");
                Console.WriteLine("----------------------");
            }
        }

        // =========================
        // Сводная информация об отделе
        // =========================
        public void GetDepartmentInfo()
        {
            int totalEmployees = Employees.Count;
            double totalSalary = 0;

            int workers = 0;
            int programmers = 0;
            int managers = 0;

            foreach (Employee emp in Employees)
            {
                totalSalary += emp.CalculateSalary();

                if (emp is Worker)
                {
                    workers++;
                }
                else if (emp is Programmer)
                {
                    programmers++;
                }
                else if (emp is Manager)
                {
                    managers++;
                }
            }

            double avgSalary = 0;

            if (totalEmployees > 0)
            {
                avgSalary = totalSalary / totalEmployees;
            }

            Console.WriteLine($"\n=== Department Info: {Name} ===");
            Console.WriteLine($"Total Employees: {totalEmployees}");
            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Average Salary: {avgSalary:F2}");

            Console.WriteLine("\nBy Type:");
            Console.WriteLine($"Workers: {workers}");
            Console.WriteLine($"Programmers: {programmers}");
            Console.WriteLine($"Managers: {managers}");
        }
    }
}