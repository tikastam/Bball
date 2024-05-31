using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Position
        {
            get { return position; }

            set
            {
                if (value == "PG" || value == "SG" || value == "SF" || value == "PF" || value == "C")
                {
                    position = value.ToUpper();
                }
                else
                {
                    position = "Invalid input";
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
