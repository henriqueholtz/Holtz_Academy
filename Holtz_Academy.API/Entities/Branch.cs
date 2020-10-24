using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Branch //Filial - Ramo
    {
        protected Branch()
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
        }
        public int BranchCode { get; private set; }
        public string BranchReason { get; private set; } //Razão
        public Status_ActiveInactive BranchStatus { get; private set; }
        public string BranchStreet { get; private set; } //Rua
        public string BranchNeighborhood { get; private set; } //Bairro
        public int BranchNumber { get; private set; } //Número
        public string BranchCityName { get; private set; } //Nome da Cidade
        public int StudentCode { get; private set; }
        public virtual Student Student { get; private set; }
        public int TeatcherCode { get; private set; }
        public virtual Teatcher Teatcher { get; private set; }


        public virtual List<Teatcher> Teatchers { get; private set; }
        public virtual List<Student> Students { get; private set; }
    }
}
