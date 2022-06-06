using System;
namespace GameProject
{
    public class GameFinishField: Field
    {
        public GameFinishField(uint _x, uint _y, Maze m) : base(_x, _y, m)
        {
            symbol = '✖';
        }

        public override void OnEnter(Player player)
        {
            player.SetCoords(x, y);
            symbol = ' ';
            disable();
            player.setWinner();
            
        }
    }
}
