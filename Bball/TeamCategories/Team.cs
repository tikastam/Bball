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

        private int dupplayer = 0;

        public List<string> hcoach = new List<string>();

        private List<string> invplayerinput = new List<string>();

        private List<Player> pwd = new List<Player>();

        private List<string> invalidinputstaff = new List<string>();

        public bool cotrue;

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
