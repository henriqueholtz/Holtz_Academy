using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Student
    {
        public int StuCode { get; set; }
        public string StudentaReason { get; set; } //Razão
        public Status_ActiveInactive StudentStatus { get; set; }
    }
}
