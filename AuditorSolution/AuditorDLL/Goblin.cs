using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditorDLL
{
    public class Goblin
    {
        public VexAdmin VA = new VexAdmin();
        private string APIROOTPATH { get; set; } = @"https://www.bungie.net/Platform";
        private string APIKEY { get; set; } = ""; // Not shared
        public DataLattice DL = new DataLattice();

        private bool SetUser()
        {
            string APICommand = APIROOTPATH + DL.GetBungieNetUserById(VA.BUNGIEID);

            return false;
        }
    }
}
