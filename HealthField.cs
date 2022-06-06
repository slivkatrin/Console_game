using System;
namespace GameProject
{
    public class HealthField: Field
    {
        private int health;
        public HealthField(uint _x, uint _y,Maze m) : base(_x, _y,m)
        {
            symbol = '♥';
            health = 25;
        }

        public override void OnEnter(Player player)
        {
            player.SetCoords(x, y);
            player.AddHealth(health);
            health = 0;
            symbol = ' ';
            disable();
        }
    }
}
    
