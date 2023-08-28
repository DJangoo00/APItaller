using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Bill : BaseEntity
    {
        public int IdServiORderFk { get; set; }
        public int IdCustomerFk { get; set; }
        public DateTime Date { get; set; }
        public int IdSubtotaldFk { get; set; }
        public int IdIvadFk { get; set; }
        public int IdJobValueFk { get; set; }
        public int Total { get; set; }
    }
}