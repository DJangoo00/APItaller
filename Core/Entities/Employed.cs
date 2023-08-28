using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Employed : Person
    {
        public string Speciality { get; set; }
        public string Status { get; set; }
    }
}