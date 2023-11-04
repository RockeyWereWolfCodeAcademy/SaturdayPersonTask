using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayPersonTask.Exceptions
{
    internal class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() 
        {

        }

        public EmployeeNotFoundException(string message) : base(message)
        {
             
        }
    }
}
