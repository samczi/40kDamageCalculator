using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    internal class Attacker
    {
        public int Attacks;
        public int HitChance;
        public int Strength;
        public int Damage;

        public Attacker(int attacks, int hitChance, int strength, int damage)
        {
            Attacks = attacks;
            HitChance = hitChance;
            Strength = strength;
            Damage = damage;
        }
    }
}
