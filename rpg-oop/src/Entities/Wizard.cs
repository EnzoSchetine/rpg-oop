using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_oop.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override void Attack(int bonus = 0, string arma = "varinha")
        {
            base.Attack(bonus, arma != "varinha" ? arma : "varinha");
        }
    }
}
