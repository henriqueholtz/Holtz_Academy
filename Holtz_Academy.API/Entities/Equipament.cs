using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Equipament
    {
        protected Equipament()
        {
        }
        public Equipament(string name, Status_Equipament status = Status_Equipament.ACTIVE)
        {
            EquipamentName = name;
            EquipamentStatus = status;
        }

        public int EquipamentCode { get; private set; }
        public string EquipamentName { get; private set; } //Name
        public Status_Equipament EquipamentStatus { get; private set; }
    }
}
