using System;
namespace wizard
{
    public class Ninja:Human
    {
        public Ninja(string n): base(n)
        {
            dexterity = 175;
        }
    
        public void Steal(object target)//method that when invoked it increases health by 10 and decreases enemys health by the same amount
        {
            Human enemy = target as Human;
                if(enemy != null) 
                {
                    attack(enemy);
                    health += 10;
                    enemy.health -=10;
                }       
        }
        public void get_away()
        {
            health -= 15;
        }
    }
}