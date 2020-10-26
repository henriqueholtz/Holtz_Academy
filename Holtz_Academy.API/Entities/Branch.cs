﻿using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Branch //Filial - Ramo
    {
        public Branch()
        {
        }
        public Branch(string branchReason, string branchStreet, string branchNeighborhood, int branchNumber, string branchCityName )
        {
            BranchReason = branchReason;
            BranchStatus = Status_ActiveInactive.ACTIVE;
            BranchStreet = branchStreet;
            BranchNeighborhood = branchNeighborhood;
            BranchNumber = branchNumber;
            BranchCityName = branchCityName;
            Teatchers = new List<Teatcher>();
            Students = new List<Student>();
            Equipaments = new List<Equipament>();
        }
        public int BranchCode { get; private set; }
        public string BranchReason { get; private set; } = null!; //Razão
        public Status_ActiveInactive? BranchStatus { get; private set; }
        public string BranchStreet { get; private set; } = null!; //Rua
        public string BranchNeighborhood { get; private set; } = null!; //Bairro
        public int? BranchNumber { get; private set; } //Número
        public string BranchCityName { get; private set; } = null!; //Nome da Cidade

        public virtual ICollection<Teatcher> Teatchers { get; private set; }
        public virtual ICollection<Student> Students { get; private set; }
        public virtual ICollection<Equipament> Equipaments { get; private set; }
    }
}
