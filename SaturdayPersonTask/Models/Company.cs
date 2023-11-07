using SaturdayPersonTask.Enums;
using SaturdayPersonTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayPersonTask.Models
{
    internal class Company
    {
        static uint _id = 0;
        public uint Id { get; set; } 
        public string Name { get; set; }

        public Company()
        {
            _id++;
            Id = _id;
        }
    }
}
