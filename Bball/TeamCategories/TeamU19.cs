using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bball.Help;

namespace Basketball
{
    public class TeamU19 : Team
    {
        private const string tt = "Juniors";

        private static readonly string hct = EnHelp.CoType.YouthCoach.ToString();

        public override string TT
        {
            get { return tt; }
        }

        public override string hctype
        {
            get { return hct; }
        }

        public override void AddPlayer(Player pl)
        {
            if (pl.Age > 19 && pl.Age < 16)
            {
                Console.WriteLine("In U19 team you can't have a player more then 19 and less then 16 years old");
            }
            else
            {
                base.AddPlayer(pl);
            }

        }


    }
}
