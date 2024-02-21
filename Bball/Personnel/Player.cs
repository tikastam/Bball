using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bball.Help;

namespace Basketball
{
    public class Player
    {
        public int ShNum;
        public string FirstName;
        public string LastName;
        private string position;
        public int Age;
        public double Heigth;
        public int points;

        public const string plinvalid = "InvalidInput";
        public string Position
        {
            get { return position; }

            set
            {
                if (value.ToUpper() == EnHelp.PlPos.PG.ToString() || value.ToUpper() == EnHelp.PlPos.SG.ToString()
                    || value.ToUpper() == EnHelp.PlPos.SF.ToString() || value.ToUpper() == EnHelp.PlPos.PF.ToString() 
                    || value.ToUpper() == EnHelp.PlPos.C.ToString())
                {
                    position = value.ToUpper();
                }
                else
                {
                    position = plinvalid;
                }
            }

        }

        public Player(int sh, string fn, string ln, string pos, double heigth, int age)
        {
            this.ShNum = sh;
            this.FirstName = fn;
            this.LastName = ln;
            this.Position = pos;
            this.Heigth = heigth;
            this.Age = age;
        }
    }
}
