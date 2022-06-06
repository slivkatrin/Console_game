using System;
namespace GameProject
{
    public abstract class Field
    {
        protected uint x;
        protected uint y;
        protected char symbol;
        protected Maze maze; // wskaznik na labirynt
        public char getSymbol()
        {
            return symbol;
        }
        public abstract void OnEnter(Player Player); //вход в комнату условие что все дети могут войти в комнату 
        public Field(uint _x, uint _y, Maze _m)
        {
            x = (uint)_x;
            y = (uint)_y;
            maze = _m;
        }
        protected void disable()
        {
            maze.SetField((int)x, (int)y, new EmptyField(x, y, maze)); //reset room after use

        }
    }
}
