using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Branch //Filial - Ramo
    {
        public int BranchCode { get; set; }
        public string BraReason { get; set; } //Razão
        public Status_ActiveInactive BranchStatus { get; set; }
        public string BranchStreet { get; set; } //Rua
        public string BranchNeighborhood { get; set; } //Bairro
        public int BranchNumber { get; set; } //Número
        public int BranchCityName { get; set; } //Nome da Cidade
    }
}
