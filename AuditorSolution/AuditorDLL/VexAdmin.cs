using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditorDLL
{
    /// <summary>
    /// Governs user information for use of API.
    /// 
    /// MEMBERTYPE: types of membership the Accounts system supports. 
    ///     Type:   int32
    ///     Values: None             0
    ///             TigerXbox        1
    ///             TigerPSN         2
    ///             TigerBlizzard    4
    ///             TigerDemon:     10
    ///             All             -1
    ///             (All is only valid for searching capabilities)
    ///             
    /// USERNAME: the full gamertag or PSN id of the player. Spaces and case are ignored by API
    ///     Type:   string
    ///     Value:  As input by user
    /// </summary>
    public class VexAdmin
    {
        public string MEMBERTYPE { get; set; } = "4"; // by default set to Blizzard, comboBox to change
        public string USERNAME { get; set; } = ""; // default null - must be entered by user.
        public string BUNGIEID { get; set; } = "00000000"; // is set by looking up member by username
    }
}
