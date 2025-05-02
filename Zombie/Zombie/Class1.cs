//written by Holbrait
//02/18/25
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieProject
{
    public class Zombie
    {
        private string name = "n/a";
        private int health = -1;
        private static int maxHealth = -1;
        private int armor = -1;
        private int damage = -1;
        private int speed = -1;
        

        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int MaxHealth { get { return Zombie.maxHealth; } set { Zombie.maxHealth = value; } }
        public int Armor { get { return armor; } set { armor = value; } }
        public int Damage { get { return damage; } set { damage = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        

        public Zombie (string _name, int _health, int _armor, int _Damage, int _Speed )
            this.Name = _name

    }
}
