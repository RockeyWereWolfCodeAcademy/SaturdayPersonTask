using SaturdayPersonTask.Enums;
using SaturdayPersonTask.Exceptions;
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
                            company.GetEmployees().ForEach(employee =>  Console.WriteLine(employee));
                            //foreach (Employee emp in company.GetEmployees())
                            //{
                            //    Console.WriteLine(emp);
                            //}
                            break;
                        case 4:
                            Console.WriteLine("Enter id to update:");
                            uint idToUpdate = Convert.ToUInt32(Console.ReadLine());
                            company.UpdateEmployee(company.GetEmployeeById(idToUpdate));
                            break;
                        case 5:
                            Console.WriteLine("Enter id to remove:");
                            uint idToRemove = Convert.ToUInt32(Console.ReadLine());
                            company.RemoveEmployee(idToRemove);
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
            Console.Write("Enter name of employee: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Select position:");
            Console.WriteLine("1. President\n2.Vice-President\n3.Marketing Manager\n4.Chief\n5.Staff");
            int position = Convert.ToInt32(Console.ReadLine());
            if (!Enum.IsDefined(typeof(GenderEnum), position))
                throw new PositionNotFoundException("There is no such option");
            Console.Write("Enter salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Select gender: ");
            Console.WriteLine("1.Male\n2.Female\n3.Other");
            int gender = Convert.ToInt32(Console.ReadLine());
            if (!Enum.IsDefined(typeof(GenderEnum), gender))
                throw new GenderNotFoundException("There is no such option");
            return new Employee()
            {
                Name = name,
                Surname = surname,
                Age = age,
                Position = (PositionEnum)position,
                Salary = salary,
                Gender = (GenderEnum)gender
            };
        }
    }
}