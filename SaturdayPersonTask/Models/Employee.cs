﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayPersonTask.Models
{
    internal class Employee : Person
    {
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public Gender Gender { get; set; }

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

    public enum Gender
    {
        Male = 1,
        Female,
        Other
    }
}
