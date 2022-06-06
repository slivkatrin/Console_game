using System;
namespace GameProject
{
    public class WallField : Field
    {
        public WallField (uint _x, uint _y,Maze m) : base(_x, _y,m)
        {
            symbol = '#';
        }

        public override void OnEnter(Player player)
        {
           //nothing
        }

    }
}

