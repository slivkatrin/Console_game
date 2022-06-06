using System;


namespace GameProject
{
    public class Character
    {
        protected string name;
        protected int health;
        protected int level;
        protected int gold;
        protected int power; // power of hit
        protected int armor;
        protected Display display;



        public void Hit(int force)
        {
            if (armor <= force) // force of hit
            {
                health -= force - armor;
            }
        }

        public bool isAlive()
        {
            return health > 0;
        }
        public void regDisplay(Display d)
        {
            display = d; 
        }

        public void Attack(Character enemy)
        {
            enemy.Hit(power);
        }

       public Character() 
        {
            
        }
        
    }
}
