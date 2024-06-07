using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Basketball
{
    public partial class Team
    {


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
                    invalidinputstaff++;
                }
            }
            ARange(sc);
        }



        private void ARange(List<Staff> li)
        {
            if (hcoach.Count != 1)
            {
                s.Clear();
            }

            else if (invalidinputstaff != 0)
            {
                s.Clear();
            }
            else
            {
                s.AddRange(li);
            }
        }

        
    }
}
