using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Data
{
    public class SeedingService
    {
        private readonly Context _context;
        public SeedingService(Context context)
        {
            _context = context;
        }
    }
}
