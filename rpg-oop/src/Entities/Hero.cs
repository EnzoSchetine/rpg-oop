using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_oop.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public string HeroType { get; private set; }
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return $"{Name} {Level} {HeroType}";
        }

        public virtual void Attack(int bonus = 0, string arma = "espada")
        {
            Console.WriteLine($"{Name} atacou com uma {arma} com um bonus de {bonus} de ataque");
        }
    }
}
