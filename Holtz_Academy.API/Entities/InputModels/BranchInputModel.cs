using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities.InputModels
{
    public class BranchInputModel
    {
        public BranchInputModel()
        {
        }
        public BranchInputModel(string branchReason, string branchStreet, string branchNeighborhood, int branchNumber, string branchCityName)
        {
            BranchReason = branchReason;
            BranchStreet = branchStreet;
            BranchNeighborhood = branchNeighborhood;
            BranchNumber = branchNumber;
            BranchCityName = branchCityName;
        }
        public string BranchReason { get; set; } = null!; //Razão
        public string BranchStreet { get; set; } = null!; //Rua
        public string BranchNeighborhood { get; set; } = null!; //Bairro
        public int? BranchNumber { get; set; } //Número
        public string BranchCityName { get; set; } = null!; //Nome da Cidade
    }
}
