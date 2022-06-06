using System;
namespace GameProject
{
    public class Monster:Character

    {
        private int exp;

        public Monster(int _power, int _gold, int _exp, int _health, int _armor)
        {
            health = _health;
            gold = _gold;
            armor = _armor;
            exp = _exp;
            power = _power;
        }
        public int GetExp() //exp to player
        {
            return exp; 
        }

    }
}
