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
        public Student(string studentReason, DateTime studentBirthDate, string studentStreet, string studentNeighborhood, int studentNumber, string studentCityName)
        {
            StudentaReason = studentReason;
            StudentStatus = Status_ActiveInactive.ACTIVE;
            StudentBirthDate = studentBirthDate;
            StudentStreet = studentStreet;
            StudentNeighborhood = studentNeighborhood;
            StudentNumber = studentNumber;
            StudentCityName = studentCityName;
        }
        public int StudentCode { get; private set; }
        public string StudentaReason { get; private set; } //Razão
        public Status_ActiveInactive StudentStatus { get; private set; }
        public DateTime StudentBirthDate { get; private set; }
        public string StudentStreet { get; private set; } //Rua
        public string StudentNeighborhood { get; private set; } //Bairro
        public int StudentNumber { get; private set; } //Número
        public string StudentCityName { get; private set; } //Nome da Cidade
    }
}
