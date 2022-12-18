using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programxo.TournamentTracker.Types
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); // New to C# 6.0
        public string TeamName { get; set; }


    }
}
