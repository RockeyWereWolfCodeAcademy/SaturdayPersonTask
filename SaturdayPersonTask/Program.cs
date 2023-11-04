using SaturdayPersonTask.Models;

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
                            //var updatedEmployee = company.GetEmployeeById(idToUpdate);
                            //Console.WriteLine("What you want to update?\n1.Name\n2.Gender\n3.Salary\n4.Position");
                            //int optionForUpdate = Convert.ToInt32(Console.ReadLine());
                            //switch (optionForUpdate)
                            //{
                            //    case 1:
                            //        Console.WriteLine("Enter new name:");
                            //        string newName = Console.ReadLine();
                            //        var newNameEmployee = company.GetEmployeeById(idToUpdate)
                            //        company.UpdateEmployee(updatedEmployee);
                            //        break;
                            //    case 2:
                            //        Console.WriteLine("Enter new gender(m/f/o): ");
                            //        string gender = Console.ReadLine();
                            //        var updatedEmployee = company.GetEmployeeById(idToUpdate);
                            //        updatedEmployee.Name = newName;
                            //        break;
                            //    case 3:
                            //        Console.WriteLine("Enter new salary:");
                            //        decimal newSalary = Convert.ToDecimal(Console.ReadLine());
                            //        break;
                            //    case 4:
                            //        Console.WriteLine("Enter new position:");
                            //        string newPosition = Console.ReadLine();
                            //        break;
                            //    default:
                            //        Console.WriteLine("There is no such option!");
                            //        break;
                            //}
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
            Console.Write("Select gender(m/f/o): ");
            string gender = Console.ReadLine();
            employee.Gender = (Employee.GenderEnum)gender[0];
            return employee;
        }

        //static Employee CreateEmployeeForUpdate()
        //{
        //    Console.WriteLine("What you want to update?\n1.Name\n2.Gender\n3.Salary\n4.Position");
        //    int option = Convert.ToInt32(Console.ReadLine());
        //    switch (option)
        //    {
        //        case 1:
        //            Console.WriteLine("Enter new name:");
        //            employee.Name = Console.ReadLine();
        //            break;
        //        case 2:
        //            Console.WriteLine("");
        //            break;
        //        case 3:
        //            Console.WriteLine("Enter new salary:");
        //            employee.Salary = Convert.ToDecimal(Console.ReadLine());
        //            break;
        //        case 4:
        //            Console.WriteLine("Enter new position:");
        //            employee.Position = Console.ReadLine();
        //            break;
        //        default:
        //            Console.WriteLine("There is no such option!");
        //            break;
        //    }
        //}
    }
}