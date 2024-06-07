using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basketball
{
    public class Game
    {

        private int mingameplayers = 8;
        public string competition;
        public DateTime DGame;

        

        private void Te(Team t)
        {

            foreach (var item in t.hcoach)
            {
                Console.WriteLine($"{item} had available for this game:\n");
            }

            foreach (var item in t.p)
            {
                Console.Write($"{item.FirstName} {item.LastName} points: ");
                item.points = int.Parse(Console.ReadLine());
                t.score += item.points;
            }
            Console.WriteLine("\n");

        }

        private void Result(Team a, Team b)
        {
            try
            {
                Te(a);
                Te(b);
                Console.WriteLine($"\nFinal result: {a.score} : {b.score}");
            }
            catch (SystemException ex)
            {
                Console.WriteLine("\nIt is necessary to enter the player's points so that the size is an integer", ex);
            }

        }

        public void PlayGame(Team t1, Team t2)
        {

            if (t1.TT != t2.TT)
            {
                Console.WriteLine($"Not the same age category teams {t1.TT} can't play against {t2.TT}");
            }
            else
            {
                if (t1.hcoach.Count == 0 || t2.hcoach.Count == 0)
                {
                    Console.Write("Team must to have a Head Coach check input for both teams");
                }
                else if (t1.hcoach.Count > 1 || t2.hcoach.Count > 1)
                {
                    
                    Console.Write("Team cannot have more then one Head Coach ");
                }
                else if (t1.invalidinputstaff != 0 || t2.invalidinputstaff != 0)
                {
                    Console.WriteLine("Some of the staff do not have valid input, corrections are needed ");
                }
                else
                {
                    
                    if(t1.dupplayer != 0 || t2.dupplayer != 0)
                    {
                        Console.WriteLine("You have a multiple players with the same Shirt Number in one of the clubs, Check your input !!! ");
                    }
                    else if (t1.invplayerinput != 0 || t2.invplayerinput != 0)
                    {
                        
                        Console.Write("Choose between PG, SG, SF, PF or C for position entry in both teams");
                    }

                    else if (t1.p.Count < mingameplayers && t1.p.Count > 0 || t2.p.Count < mingameplayers && t2.p.Count > 0)
                    {
                        Console.WriteLine("Not enough players in one of the team to play this game you should have minimum" + mingameplayers + " players in rotation!!!");
                    }
                    else
                    {
                        Console.WriteLine($"\n{competition} game {DGame}\n");
                        Result(t1, t2);
                    }
                }
            }
        }

        public Game(string comp, DateTime dg)
        {
            this.competition = comp;
            this.DGame = dg;
        }



    }
}
