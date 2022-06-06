using System;
namespace GameProject
{
    public class Display
    {
        Maze localMaze; //!
        Player player;
        string[] lines = { "", "", "", "" };
        public Display(Maze m, Player pl)
        {
            localMaze = m;
            player = pl;
        }
        public void getStats()
        {
            string stats = player.GetStats();
            Console.WriteLine(stats);
        }
        public void PrintLines()
        {
            Console.WriteLine($">{lines[0]}");
            Console.WriteLine($">{lines[1]}");
            Console.WriteLine($">{lines[2]}");
            Console.WriteLine($">{lines[3]}");
        }
        public void AddLine(string displayText)
        {
            lines[3] = lines[2];
            lines[2] = lines[1];
            lines[1] = lines[0];
            lines[0] = displayText;
        }
        public void drawMaze()
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < localMaze.getSizeY(); i++ ) //for each string do
            {
                for (j = 0; j < localMaze.getSizeX(); j++)// for each column in the line, make an entrance - вход в тело 
                {
                    if (player.getCoordsX() == j && player.getCoordsY() == i)// if the player is standing at the place of drawing - show him there
                    {
                        Console.Write("P"); // player
                    }
                    else // otherwise, show the room in which the room symbol is located
                    {
                        Console.Write(localMaze.GetFieldSymbol(j, i));// 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}




