using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayPersonTask.Models
{
    internal static class CompanyDatabase
    {
        public static List<Company> Companies { get; set; } = new List<Company>();
        public static List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
