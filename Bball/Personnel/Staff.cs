using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bball.Help;

namespace Basketball
{
    public class Staff
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        private string type { get; set; }

        public const string coinv = "Invalidinput";
        public string Type
        {
            get { return type; }

            set
            {
                if (value == EnHelp.CoType.HeadCoach.ToString() || value == EnHelp.CoType.AssistantCoach.ToString()
                    || value == EnHelp.CoType.FitnessCoach.ToString() || value == EnHelp.CoType.Doctor.ToString()
                    || value == EnHelp.CoType.Physiotherapist.ToString() || value == EnHelp.CoType.YouthCoach.ToString())
                {
                    type = value;
                }
                else
                {
                    type = coinv;
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
