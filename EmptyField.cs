using System;
namespace GameProject
{
    public class EmptyField : Field
    {

        public EmptyField(uint _x, uint _y,Maze m) : base(_x, _y,m)
        {
            symbol = ' ';
        }

        public override void OnEnter(Player player)
        {
            player.SetCoords(x, y);

        }
    }
}
