using System;
namespace GameProject
{
    public class MonsterField : Field
    {
        private Monster localmonster;
        public MonsterField(uint _x, uint _y,Maze m,Monster Mon) : base(_x, _y,m)
        {
            symbol = 'M';
            localmonster = Mon;
        }
        
        public override void OnEnter(Player player)
        {
            
                localmonster.Attack(player);
                player.Attack(localmonster);

            if (!localmonster.isAlive()) // if you killed the monster
            {
                player.SetCoords(x, y);
                player.AddXP(localmonster.GetExp()) ;
                localmonster = null;
                disable();
            }
            
        }
    }
}
