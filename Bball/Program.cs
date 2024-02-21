using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basketball
{
    class Program
    {
        static void Main(string[] args)
        {
            // HeadCoach, AssistantCoach, FitnessCoach, Doctor, Physiotherapist, YouthCoach - for Type Staff

            // PG, SG, SF, PF, C - for Player position


            Team Partizan = new Team();

            Player AA = new Player(4, "Aleksa", "Avramovic", "PG", 192, 30);
            Player KP = new Player(7, "Kevin", "Punter", "sg", 193, 31);
            Player JN = new Player(21, "James", "Nunnaly", "SF", 201, 34);
            Player ZL = new Player(2, "Zach", "Leday", "PF", 202, 30);
            Player BC = new Player(50, "Bruno", "Caboclo", "C", 206, 29);

            Partizan.AddPlayer(AA);
            Partizan.AddPlayer(KP);
            Partizan.AddPlayer(JN);
            Partizan.AddPlayer(ZL);
            Partizan.AddPlayer(BC);
            
            


            Staff ZO = new Staff("Zeljko", "Obradovic", "HeadCoach");
            Staff BCA = new Staff("Bogdan", "Karaicic", "AssistantCoach");
            Staff AM = new Staff("Aleksandar", "Matovic", "AssistantCoach");
            Staff PZ = new Staff("Predrag", "Zimonjic", "FitnessCoach");
            Staff MM = new Staff("Milan", "Macvan", "YouthCoach");

            Partizan.AddStaff(ZO);
            Partizan.AddStaff(BCA);
            Partizan.AddStaff(PZ);
            Partizan.AddStaff(ZO);
            Partizan.AddStaff(AM);
            Partizan.AddStaff(MM);


            

            Team RealMadrid = new Team();

            Player SL = new Player(23, "Sergio", "Llull", "PG", 195, 37);
            Player SR = new Player(13, "Sergio", "Rodriguez", "SG", 195, 38);
            Player DM = new Player(31, "Dzanan", "Musa", "SF", 205, 25);
            Player MH = new Player(11, "Mario", "Hezonja", "PF", 203, 29);
            Player WT = new Player(22, "Walter", "Tavares", "C", 221, 32);

            RealMadrid.AddPlayer(SL);
            RealMadrid.AddPlayer(SR);
            RealMadrid.AddPlayer(DM);
            RealMadrid.AddPlayer(MH);
            RealMadrid.AddPlayer(WT);

            Staff CM = new Staff("Cus", "Mateo", "HeadCoach");

            RealMadrid.AddStaff(CM);


            Game EL = new Game("Euroleague", new DateTime(2024, 2, 11, 20, 45, 0));

            EL.PlayGame(Partizan, RealMadrid);




            Console.ReadLine();
        }
    }
}
