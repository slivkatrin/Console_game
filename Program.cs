using System;
using System.Linq;

namespace GameProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Maze maze = new Maze();
            Player pl = new Player("Merlin",maze);
            Display display = new Display(maze, pl);
            pl.regDisplay(display); // przekazanie obj wys do character
            while (!pl.getWinner())
            {
                Console.Clear();
                display.PrintLines();
                display.drawMaze();
                display.getStats();
                char key = Console.ReadKey().KeyChar; // naciskanie wasd
                pl.Move(key);
                if (!pl.isAlive()) //dead
                {
                    break;
                }

            }
            if (pl.getWinner())
            {
                Console.WriteLine("Congratulation!!!!!");
            }
            else
            {
                Console.WriteLine("Game over");
            }
        }
    }
}
