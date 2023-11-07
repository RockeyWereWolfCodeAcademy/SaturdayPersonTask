using SaturdayPersonTask.Enums;
using SaturdayPersonTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayPersonTask.Models
{
    internal class Employee : Person
    {
        public DateTime CreatedAt { get; set; }
        public decimal Salary { get; set; }
        PositionEnum _position;
        public PositionEnum Position { get => _position;
            set
            {
                if (!Enum.IsDefined(typeof(PositionEnum), value))
                    throw new PositionNotFoundException("There is no such option");
                _position = value;
            }
        }
        GenderEnum _gender;
        public GenderEnum Gender { get => _gender; set 
            {
                if (!Enum.IsDefined(typeof(GenderEnum), value))
                    throw new GenderNotFoundException("There is no such option");
                _gender = value;
            } 
        }

        public override string ToString()
        {
            return $"{Id}. Fullname: {Fullname()}, Gender: {Gender}, Age: {Age}, Salary: {Salary}, Position: {Position}";
        }

        public Employee()
        {
            _id++;
            Id = _id;
        }
    }
    
}
