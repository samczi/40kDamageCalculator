using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    internal class Attacker
    {
        public int Attacks {  get; private set; }
        public int HitChance { get; private set; }
        public int Strength { get; private set; }
        public int Damage { get; private set; }
        public int ArmorPiercing { get; private set; }

        public Attacker(int attacks, int hitChance, int strength, int damage, int armorPiercing)
        {
            Attacks = attacks;
            HitChance = hitChance;
            Strength = strength;
            Damage = damage;
            ArmorPiercing = armorPiercing;
        }
        public 
    }
}
