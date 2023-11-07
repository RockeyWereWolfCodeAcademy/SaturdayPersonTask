using SaturdayPersonTask.Enums;
using SaturdayPersonTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayPersonTask.Models
{
    internal static class EmployeeService
    {
        public static void AddEmployee(Employee employee)
        {
            CompanyDatabase.Employees.Add(employee);
        }

        public static Employee GetEmployeeById(uint id)
        {
            var employee = CompanyDatabase.Employees.Find(employee => employee.Id == id);
            if (employee != null)
                return employee;
            throw new EmployeeNotFoundException("There is no employee with such ID");
        }

        public static void UpdateEmployee(Employee employee)
        {
            Console.WriteLine("What you want to update?\n1.Name\n2.Gender\n3.Salary\n4.Position");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter new name:");
                    employee.Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Select gender: ");
                    Console.WriteLine("1.Male\n2.Female\n3.Other");
                    //if (!Enum.IsDefined(typeof(Gender), input))
                    //    throw new ArgumentOutOfRangeException();
                    employee.Gender = (GenderEnum)Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter new salary:");
                    employee.Salary = Convert.ToDecimal(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Select position:");
                    Console.WriteLine("1. President\n2.Vice-President\n3.Marketing Manager\n4.Chief\n5.Staff");
                    employee.Position = (PositionEnum)Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("There is no such option!");
                    break;
            }
        }

        public static void RemoveEmployee(uint id)
        {
            CompanyDatabase.Employees.Remove(GetEmployeeById(id));
        }

        public static List<Employee> GetEmployees()
        {
            return CompanyDatabase.Employees;
        }

        public static List<Employee> GetEmployeesByValue(string value)
        {
            return CompanyDatabase.Employees.FindAll(employee => employee.Name.Contains(value) || employee.Surname.Contains(value));
        }

        public static List<Employee> GetLatestEmployees()
        {
            var calendar = DateTimeFormatInfo.CurrentInfo.Calendar;
            return CompanyDatabase.Employees.FindAll(employee =>
            {
                int currentWeek = calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                int creationWeek = calendar.GetWeekOfYear(employee.CreatedAt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                return creationWeek == currentWeek;
            });
        }
    }
}
