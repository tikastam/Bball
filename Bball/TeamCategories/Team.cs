using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bball.Help;

namespace Basketball
{
    public class Team
    {
        public List<Player> p = new List<Player>();

        public List<Staff> s = new List<Staff>();

        private List<int> dupplayer = new List<int>();

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

        private void HelpPlayer()
        {
            pwd = p.OrderBy(a => a.ShNum).ToList();

            for (int i = 0; i < pwd.Count - 1; i++)
            {
                if (pwd[i].ShNum == pwd[i + 1].ShNum)
                {
                    dupplayer.Add(pwd[i].ShNum);
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

            if (dupplayer.Count != 0)
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
            if (dupplayer.Count != 0)
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

        private void ClList()
        {
            if (s.Count == 0)
            {
                cotrue = false;
            }
            else
            {
                cotrue = true;
            }
        }

        public void AddStaff(Staff st)
        {
             List<Staff> sc = new List<Staff>();

            sc.Add(st);

            for (int i = 0; i < sc.Count; i++)
            {
                if (sc[i].Type == hctype)
                {
                    hcoach.Add(sc[i].Fname + " " + sc[i].Lname);
                }
                else if (sc[i].Type == Staff.coinv)
                {
                    invalidinputstaff.Add(sc[i].Type);
                }
            }
            if(hcoach.Count != 1)
            {
                s.Clear();
            }

            else if (invalidinputstaff.Count != 0)
            {
                s.Clear();
            }
            else
            {
                s.AddRange(sc);
            }

            ClList();
        }






        public void ChStaff()
        {

            if (hcoach.Count == 0)
            {
                s.Clear();
                Console.Write("Team must to have a Head Coach ");
            }
            else if (hcoach.Count > 1)
            {
                s.Clear();
                Console.Write("Team cannot have more then one Head Coach ");
            }
            else if (invalidinputstaff.Count != 0)
            {
                s.Clear();
                Console.WriteLine("Some of the staff do not have valid input, corrections are needed ");
            }

            else
            {
                foreach (var item in s)
                {
                    Console.WriteLine($"{item.Fname} {item.Lname} - {item.Type}");
                }
            }
        }


    }
}
