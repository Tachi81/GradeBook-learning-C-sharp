using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Monster
    {
        private int HealthPoints;
        public int Attack;
        public string Description;
        string Name;

        public Monster(int hp, int attack, string description = "Scary monster in da House", string name= "Jozek")
        {
            HealthPoints = hp;
            Attack = attack;
            Description = description;
            Name = name;
        }

        public int ShowHp()
        {
            return HealthPoints;
        }



        public void  Heal(int amount)
        {
            HealthPoints += amount;
            Console.WriteLine(Name + "was healed and his hp now is  "+ HealthPoints);
        }
        public void Damage (int amount)
        {
            HealthPoints -= amount;
            Console.WriteLine(Name + "was hit and his hp now is  " + HealthPoints);
        }

        public void Poison()
        {
            HealthPoints -= 40;
        }

        public override string ToString()
        {
            return Attack.ToString();
        }
    }
}
