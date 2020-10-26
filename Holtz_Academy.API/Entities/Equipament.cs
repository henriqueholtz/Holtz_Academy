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
        public Equipament(string name, Status_Equipament status = Status_Equipament.ACTIVE, int branchCode = 0)
        {
            EquipamentName = name;
            EquipamentStatus = status;
            BranchBranchCode = branchCode;
        }

        public int EquipamentCode { get; private set; }
        public string EquipamentName { get; private set; } = null!; //Name
        public Status_Equipament? EquipamentStatus { get; private set; }

        public int? BranchBranchCode { get; private set; }
        public virtual Branch Branch { get; private set; }
    }
}
