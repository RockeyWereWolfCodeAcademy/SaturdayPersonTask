using SaturdayPersonTask.Models;
using System;

namespace SaturdayPersonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            int option = -1;
            while (option != 0) 
            {
                Console.WriteLine("Choose from options: \n1. Create an employee\n2. Get employee details by id\n3. Get all employees" +
                "\n4. Update employee details by id\n5. Delete employee records by id\n0. Exit program");
                option = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (option)
                    {
                        case 1:
                            company.AddEmployee(CreateEmployee());
                            break;
                        case 2:
                            Console.WriteLine("Enter id to get:");
                            uint idToGet = Convert.ToUInt32(Console.ReadLine());
                            Console.WriteLine(company.GetEmployeeById(idToGet));
                            break;
                        case 3:
                            foreach (Employee emp in company.GetEmployees())
                            {
                                Console.WriteLine(emp);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter id to update:");
                            uint idToUpdate = Convert.ToUInt32(Console.ReadLine());
                            company.UpdateEmployee(company.GetEmployeeById(idToUpdate));
                            break;
                        case 5:
                            Console.WriteLine("Enter id to remove:");
                            uint idToRemove = Convert.ToUInt32(Console.ReadLine());
                            company.RemoveEmployee(company.GetEmployeeById(idToRemove));
                            break;
                        case 0:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("No such option!");
                            break;

                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            

        }
        static Employee CreateEmployee()
        {
            Employee employee = new Employee();
            Console.Write("Enter name of employee: ");
            employee.Name = Console.ReadLine();
            Console.Write("Enter surname: ");
            employee.Surname = Console.ReadLine();
            Console.Write("Enter age: ");
            employee.Age = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter position: ");
            employee.Position = Console.ReadLine();
            Console.Write("Enter salary: ");
            employee.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Select gender: ");
            Console.WriteLine("1.Male\n2.Female\n3.Other");
            int input = Convert.ToInt32(Console.ReadLine());
            if (!Enum.IsDefined(typeof(Gender), input))
                throw new ArgumentOutOfRangeException();
            employee.Gender = (Gender)input;
            return employee;
        }
    }
}