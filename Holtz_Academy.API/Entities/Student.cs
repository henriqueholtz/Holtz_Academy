using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Student
    {
        protected Student()
        {
        }
        public Student(string studentReason, DateTime studentBirthDate, string studentStreet, string studentNeighborhood, int studentNumber, string studentCityName, int teatcherCode)
        {
            StudentaReason = studentReason;
            StudentStatus = Status_ActiveInactive.ACTIVE;
            StudentBirthDate = studentBirthDate;
            StudentStreet = studentStreet;
            StudentNeighborhood = studentNeighborhood;
            StudentNumber = studentNumber;
            StudentCityName = studentCityName;
            TeatcherCode = teatcherCode;
        }
        public int StudentCode { get; private set; }
        public string StudentaReason { get; private set; } //Razão
        public Status_ActiveInactive StudentStatus { get; private set; }
        public DateTime StudentBirthDate { get; private set; }
        public string StudentStreet { get; private set; } //Rua
        public string StudentNeighborhood { get; private set; } //Bairro
        public int StudentNumber { get; private set; } //Número
        public string StudentCityName { get; private set; } //Nome da Cidade


        public int TeatcherCode { get; private set; }
        public virtual Teatcher Teatcher { get; private set; }

        public int BranchCode { get; private set; }
        public Branch Branch { get; private set; }
    }
}
