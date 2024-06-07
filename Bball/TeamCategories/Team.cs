using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bball.Help;

namespace Basketball
{

    //Purpose of this class is adding staff and players
    //Logic for this tasks can be found in the Help folder 
    //Team Players and TeamStaff files

    public partial class Team
    {
        public List<Player> p = new List<Player>();

        public List<Staff> s = new List<Staff>();

        public int dupplayer = 0;

        public int invplayerinput = 0;

        public List<string> hcoach = new List<string>();

        private List<Player> pwd = new List<Player>();

        public int invalidinputstaff;

        private const string tt = "Seniors";

        private static readonly string hct = EnHelp.CoType.HeadCoach.ToString();

        public int score { get; set; }

        public virtual string TT
        {
            get { return tt; }
        }

        public virtual string hctype
        {
            get { return hct; }
        }

        

        


    }
}
