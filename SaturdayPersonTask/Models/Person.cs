using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdayPersonTask.Models
{
    abstract class Person
    {
        protected static uint _id = 0;
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public virtual string Fullname()
        {
            return Name + " " + Surname;
        }
    }
}
