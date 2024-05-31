using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    public class Team
    {
        public List<Player> p = new List<Player>();

        public List<Staff> s = new List<Staff>();

        private List<int> dup = new List<int>();

        public List<Staff> hc = new List<Staff>();

        private List<string> iinput = new List<string>();

        private List<Player> pwd = new List<Player>();

        private List<string> iinstaff = new List<string>();

        public bool cotrue;

        private string tt = "Seniors";

        public int score { get; set; }

        public virtual string TT
        {
            get { return tt; }
        }

        public virtual string hctype
        {
            get { return "Head Coach"; }
        }

        private void HelpPlayer()
        {
            pwd = p.OrderBy(a => a.ShNum).ToList();

            for (int i = 0; i < pwd.Count - 1; i++)
            {
                if (pwd[i].ShNum == pwd[i + 1].ShNum)
                {
                    dup.Add(pwd[i].ShNum);
                }
            }
            for (int i = 0; i < pwd.Count; i++)
            {
                if (pwd[i].Position == "Invalid input")
                {
                    iinput.Add(pwd[i].Position);
                }
            }
        }

        public virtual void AddPlayer(Player pl)
        {
            p.Add(pl);
            HelpPlayer();

            if (dup.Count != 0)
            {
                p.Clear();

            }
            if (iinput.Count != 0)
            {
                p.Clear();
            }
        }

        public void Players()
        {
            if (dup.Count != 0)
            {
                p.Clear();
                Console.Write("You have multiple players with same Shirt Number, Check your input !!!");
            }
            if (iinput.Count != 0)
            {
                p.Clear();
                Console.Write("Choose between PG, SG, SF, PF or C for position entry");
            }
            else
            {
                foreach (var item in p)
                {
                    Console.WriteLine($"{item.ShNum} {item.FirstName} {item.LastName} {item.Position} {item.Heigth}cm {item.Age}");
                }
            }
        }
        public void AddStuff(Staff st)
        {
            List<Staff> sc = new List<Staff>();

            sc.Add(st);

            for (int i = 0; i < sc.Count; i++)
            {
                if (sc[i].Type == hctype)
                {
                    hc.Add(sc[i]);
                }
                else if (sc[i].Type == "Invalid input")
                {
                    iinstaff.Add(sc[i].Type);
                }
            }

            if (hc.Count == 0)
            {
                s.Clear();
            }
            else if (hc.Count > 1)
            {
                s.Clear();
            }
            else if (iinstaff.Count != 0)
            {
                s.Clear();
            }

            else
            {
                s.AddRange(sc);
            }
            if (s.Count == 0)
            {
                cotrue = false;
            }
            else
            {
                cotrue = true;
            }
        }
        public void Staff()
        {

            if (hc.Count == 0)
            {
                Console.Write("Team must to have a Head Coach");
            }
            else if (hc.Count > 1)
            {
                Console.Write("Team cannot have more then one Head Coach");
            }
            else if (iinstaff.Count != 0)
            {
                Console.WriteLine("Some of the staff do not have valid input, corrections are needed");
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
