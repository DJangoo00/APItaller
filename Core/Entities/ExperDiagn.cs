using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ExperDiagn : BaseEntity
    {
        public string Descr { get; set; }
        public int IdEmployedFk { get; set; }
    }
}