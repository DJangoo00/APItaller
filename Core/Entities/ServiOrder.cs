using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ServiOrder : BaseEntity
    {
        public int IdClienteFk { get; set; }
        public int IdEmployedFk { get; set; }
        public DateTime OrderDate { get; set; }
        public int IdVehicleFk { get; set; }
        public int Km { get; set; }
        public string DiagnCust { get; set; }
        public int IdExperDiagnFk { get; set; }
    }
}