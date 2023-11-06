using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayPersonTask.Exceptions
{
    internal class GenderNotFoundException : Exception
    {
        public GenderNotFoundException() { }
        public GenderNotFoundException(string message) : base(message)
        {
            
        }
    }
}
