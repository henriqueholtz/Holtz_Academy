using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Equipament
    {

        public int EquipamentCode { get; private set; }
        public string EquipamentReason { get; private set; } //Razão
        public Status_Equipament EquipamentStatus { get; private set; }
    }
}
