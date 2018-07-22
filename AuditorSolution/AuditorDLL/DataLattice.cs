using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditorDLL
{
    public class DataLattice
    {
        public string GetBungieNetUserById(string BungieId)
        {
            return @"/User/GetBungieNetUserById/" + BungieId + @"/";
        }
    }
}
