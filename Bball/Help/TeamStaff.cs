using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Basketball
{
    public partial class Team
    {
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
            if (hcoach.Count != 1)
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
