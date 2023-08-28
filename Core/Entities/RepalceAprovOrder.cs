using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RepalceAprovOrder
    {
        public int IdReplaceFk { get; set; }
        public int IdAprovOrderFk { get; set; }
    }
}