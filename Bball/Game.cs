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
                if (!t1.cotrue || !t2.cotrue)
                {
                    Console.WriteLine("An error occurred when entering data for staff - check the input in both teams ");
                }
                else
                {
                    Console.WriteLine($"\n{competition} game {DGame}\n");
                    if (t1.p.Count == 0 || t2.p.Count == 0)
                    {
                        Console.WriteLine(string.Empty);
                    }

                    else if (t1.p.Count < mingameplayers && t1.p.Count > 0 || t2.p.Count < mingameplayers && t2.p.Count > 0)
                    {
                        Console.WriteLine("Not enough players in one of the team to play this game you should have minimum" + mingameplayers + " players in rotation!!!");
                    }
                    else
                    {
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
