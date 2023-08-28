using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Vehicle : BaseEntity
    {
        public int IdClienteFk { get; set; }
        public string LicPlate { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
    }
}