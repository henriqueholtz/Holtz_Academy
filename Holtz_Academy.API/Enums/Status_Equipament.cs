using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Enums
{
    public enum Status_Equipament : byte
    {
        INACTIVE = 0,
        ACTIVE = 1,
        MANUTENTION = 2,
        BROKE = 3
    }
}
