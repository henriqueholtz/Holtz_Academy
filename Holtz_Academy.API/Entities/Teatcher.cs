using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Teatcher
    {
        protected Teatcher()
        {
        }
        public Teatcher(string teatcherReason, DateTime teatcherBirthDate, string teatcherStreet, string teatcherNeighborhood, int teatcherNumber, string teatcherCityName)
        {
            TeatcherReason = teatcherReason;
            TeatcherStatus = Status_ActiveInactive.ACTIVE;
            TeatcherBirthDate = teatcherBirthDate;
            TeatcherStreet = teatcherStreet;
            TeatcherNeighborhood = teatcherNeighborhood;
            TeatcherNumber = teatcherNumber;
            TeatcherCityName = teatcherCityName;
            Students = new List<Student>();
        }
        public int TeatcherCode { get; set; }
        public string TeatcherReason { get; set; } //Razão
        public Status_ActiveInactive TeatcherStatus { get; set; }
        public DateTime TeatcherBirthDate { get; private set; }
        public string TeatcherStreet { get; private set; } //Rua
        public string TeatcherNeighborhood { get; private set; } //Bairro
        public int TeatcherNumber { get; private set; } //Número
        public string TeatcherCityName { get; private set; } //Nome da Cidade


        public int BranchCode { get; private set; }
        public Branch Branch { get; private set; }
        public List<Student> Students { get; private set; }
    }
}
