using System;
namespace GameProject
{
    public class Player : Character
    {
        
        private Maze maze;
        private int xp;
        private bool winner;
        public Player(string in_name,Maze m)
        {

            Console.WriteLine("Konstruktor Player");

            name = in_name; // konstruktor
            power = 15;
            level = 0;
            health = 100;
            gold++; // na początek ++ bo jestesmy mili
            maze = m;
            xp = 0;
            winner = false;
            

        }

        public void setWinner()
        {
            winner = true;
        }

        public bool getWinner()
        {
            return winner;
        }

        public void Move(char key)
        {
            try
            {
                if ('w' == key)
                {
                    maze.GetField((int)coordX, (int)coordY-1).OnEnter(this);
                }
                if ('a' == key)
                {
                    maze.GetField((int)coordX-1, (int)coordY).OnEnter(this);
                }
                if ('s' == key)
                {
                    maze.GetField((int)coordX, (int)coordY + 1).OnEnter(this);
                }
                if ('d' == key)
                {
                    maze.GetField((int)coordX+1, (int)coordY).OnEnter(this);
                }
            }
            catch
            {
                //do nothing
            }
        }

        public void SetCoords(uint x, uint y)
        {
            coordX = x;
            coordY = y;
        }
            protected uint coordX;
            protected uint coordY;

        public void AddHealth(int incHealth) // add health to player
        {
            health = health + incHealth;

            display.AddLine($"Health added + {incHealth}");
        }

        public void AddGold(int incGold) // add gold to player
        {
            gold = gold + incGold;
           
           display.AddLine($"Gold added + {incGold}");
        }

        public void KillMonster(int incLVL) 
        {
            level = level + incLVL;

            display.AddLine($"Monster killed + {incLVL} EXP");
        }
        
        public void AddXP(int _xp) // lvl up 
        {
                xp += _xp;
                if (xp >= 2)
                {
                level++;
                power += 3;// new level +power
                xp = xp - 2;
                }
            display.AddLine($"Monster killed + {_xp} EXP");

        }

        public uint getCoordsX()
        {
            return coordX;
        }

        public uint getCoordsY()
        {
            return coordY;
        }

        public string GetStats()
        {
            string s = String.Format("\n Name: {0} Level: {1} Gold: {2} Health: {3}", name, level, gold, health);
            return s;


        }
    }
    }
    

    

