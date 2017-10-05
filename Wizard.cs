using System;
namespace wizard
{
    public class Witch:Human
    {
        public Witch(string n): base(n)
        {
            intelligence = 25;
            health = 50;
        }
    

        public void heal() //method that when invoked heals the Wizard by 10 * Intelligence
        {
            health += 10 * intelligence;
        }
        public void fireball(object target) //method that when invoked it decreasesits target by a random number betwenn 20 and 50
        {
            Human enemy = target as Human;
                if(enemy != null) 
                {
                    Random rand = new Random();
                    enemy.health -= rand.Next(20, 51);
                }
        }
    }
}