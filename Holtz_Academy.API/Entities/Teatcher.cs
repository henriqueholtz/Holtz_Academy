using Holtz_Academy.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Entities
{
    public class Teatcher
    {
        public int TeatcherCode { get; set; }
        public string TeatcherReason { get; set; } //Razão
        public Status_ActiveInactive TeatcherStatus { get; set; }
    }
}
