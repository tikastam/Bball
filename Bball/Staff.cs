using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    public class Staff
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        private string type { get; set; }
        public string Type
        {
            get { return type; }

            set
            {
                if (value == "Head Coach" || value == "Assistant Coach" || value == "Fitness Coach" || value == "Doctor" || value == "Physiotherapist" || value == "Youth Coach")
                {
                    type = value;
                }
                else
                {
                    type = "Invalid input";
                }
            }
        }


        public Staff(string fname, string lname, string type)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Type = type;
        }


    }
}
