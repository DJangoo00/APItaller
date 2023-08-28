using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Repalce : BaseEntity
    {
        public string Name { get; set; }
        public int IndiValue { get; set;}
        public int Cant { get; set;}
        public string Status { get; set;}
    }
}