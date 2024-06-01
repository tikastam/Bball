using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    public partial class Team
    {

        // Players Operations


        private void HelpPlayer()
        {

            pwd = p.OrderBy(a => a.ShNum).ToList();

            for (int i = 0; i < pwd.Count - 1; i++)
            {
                if (pwd[i].ShNum == pwd[i + 1].ShNum)
                {
                    p.Clear();
                    dupplayer++;
                }
            }
            for (int i = 0; i < pwd.Count; i++)
            {
                if (pwd[i].Position == Player.plinvalid)
                {
                    p.Clear();
                    invplayerinput ++;
                }
            }
        }

        public virtual void AddPlayer(Player pl)
        {

            p.Add(pl);
            HelpPlayer();
            
        }

    }
}
