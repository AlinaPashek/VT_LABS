//Program.cs
using OOP_COLLECTIONS;
using System;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // 1. Создать отдел с названием "IT"
        // =========================
        Department department = new Department("IT");

        // =========================
        // 2. Создать 2-х рабочих
        // =========================
        Worker worker1 = new Worker("Ivan", 1200, 22);
        Worker worker2 = new Worker("Petr", 1100, 18);

        // =========================
        // 3. Создать 2-х программистов
        // =========================
        Programmer programmer1 = new Programmer("Anna", 2000, "Junior");
        Programmer programmer2 = new Programmer("Oleg", 3000, "Senior");

        // =========================
        // 4. Создать 1-го менеджера
        // =========================
        Manager manager = new Manager("Sergey", 3500, 8);

        // =========================
        // 5. Добавить всех сотрудников в отдел
        // =========================
        department.AddEmployee(worker1);
        department.AddEmployee(worker2);
        department.AddEmployee(programmer1);
        department.AddEmployee(programmer2);
        department.AddEmployee(manager);

        // =========================
        // 6. Вывести всех сотрудников отдела
        // =========================
        Console.WriteLine("=== Все сотрудники отдела ===");
        department.ShowAllEmployees();

        // =========================
        // 7. Найти сотрудников с Id 1, 3, 7
        // =========================
        Console.WriteLine("\n=== Тестируем поиск сотрудника ===");

        int[] idsToFind = { 1, 3, 7 };

        foreach (int id in idsToFind)
        {
            Employee? employee = department.FindEmployeeById(id);

            if (employee != null)
            {
                Console.WriteLine($"\nСотрудник с Id = {id} найден:");
                employee.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"\nСотрудник с Id = {id} не найден.");
            }
        }

        // =========================
        // 8. Удалить сотрудника с Id = 2
        // =========================
        Console.WriteLine("\n=== Тестируем удаление сотрудника ===");

        bool isRemoved = department.RemoveEmployeeById(2);
        Console.WriteLine($"Удаление сотрудника с Id = 2: {isRemoved}");

        // =========================
        // 9. Вывести всех сотрудников после удаления
        // =========================
        Console.WriteLine("\n=== После удаления ===");
        department.ShowAllEmployees();

        // =========================
        // 10. Вывести сводную информацию об отделе
        // =========================
        Console.WriteLine("\n=== Статистика отдела ===");
        department.GetDepartmentInfo();
    }
}