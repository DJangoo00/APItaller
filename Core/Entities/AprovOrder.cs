using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class AprovOrder : BaseEntity
    {
        public int IdEmployedFk { get; set; }
        public string Status { get; set;}
        public DateTime Date { get; set;}
    }
}