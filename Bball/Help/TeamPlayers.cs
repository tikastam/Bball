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
                    dupplayer++;
                }
            }
            for (int i = 0; i < pwd.Count; i++)
            {
                if (pwd[i].Position == Player.plinvalid)
                {
                    invplayerinput.Add(pwd[i].Position);
                }
            }
        }

        public virtual void AddPlayer(Player pl)
        {
            p.Add(pl);
            HelpPlayer();

            if (dupplayer != 0)
            {
                p.Clear();
                Players();
            }
            if (invplayerinput.Count != 0)
            {
                p.Clear();
                Players();
            }
        }

        public void Players()
        {
            if (dupplayer != 0)
            {
                Console.WriteLine("You have a multiple players with same Shirt Number, Check your input !!! ");
            }
            if (invplayerinput.Count != 0)
            {
                Console.Write("Choose between PG, SG, SF, PF or C for position entry ");
            }
            else
            {
                foreach (var item in p)
                {
                    Console.WriteLine($"{item.ShNum} {item.FirstName} {item.LastName} {item.Position} {item.Heigth}cm {item.Age}");
                }
            }
        }
    }
}
