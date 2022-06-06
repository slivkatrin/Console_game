using System;
namespace GameProject
{
    public class GoldField : Field
    {
        private int gold;
        public GoldField(uint _x, uint _y,Maze m) : base(_x, _y,m)
        {
            symbol = '$';
            gold = 3; //todo: ustawic losowa wartosc
        }

        public override void OnEnter(Player player)
        {
            player.SetCoords(x, y);
            player.AddGold(gold);
             gold = 0;
             symbol = ' ';
             disable();
        }
    }
}
