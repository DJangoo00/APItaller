using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Customer : Person
    {
        public string Email { get; set; }
        public DateTime RegisDate { get; set; }
    }
}