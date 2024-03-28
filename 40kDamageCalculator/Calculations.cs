using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    internal class Calculations
    {
        private Attacker attacker;
        private Defender defender;

        public Calculations(Attacker attacker, Defender defender)
        {
            this.attacker = attacker;
            this.defender = defender;
        }

        public decimal CalculateAverageDamage()
        {
            return attacker.Attacks * DetermineHitChance() * DetermineWoundChance() * DetermineArmorSaveChance() * DetermineDamage();
        }
        private decimal DetermineHitChance()
        {
            int hitChance = attacker.HitChance;
            if      (hitChance == 6) { return 1 / 6; }
            else if (hitChance == 5) { return 1 / 3; }
            else if (hitChance == 4) { return 1 / 2; }
            else if (hitChance == 3) { return 2 / 3; }
            else if (hitChance == 2) { return 5 / 6; }
            else if (hitChance == 1) { return 5 / 6; }
            throw new ArgumentOutOfRangeException();
        }
        private decimal DetermineWoundChance()
        {
            decimal proportion = defender.Toughness / attacker.Strength;
            if      (proportion > 2 )    { return 1 / 6; }
            else if (proportion > 1 )    { return 1 / 3; }
            else if (proportion == 1 )   { return 1 / 2; }
            else if (proportion > 0.5m ) { return 2 / 3; }
            else                         { return 5 / 6; }
        }
        private decimal DetermineArmorSaveChance()
        {
            decimal armor = defender.Armor + attacker.ArmorPiercing;
            if      (armor > 6)  { return 1; }
            else if (armor == 6) { return 5 / 6; }
            else if (armor == 5) { return 1 / 3; }
            else if (armor == 4) { return 1 / 2; }
            else if (armor == 3) { return 2 / 3; }
            else if (armor <= 2) { return 5 / 6; }
            throw new ArgumentOutOfRangeException();
        }
        private decimal DetermineDamage()
        {
            decimal damage = attacker.Damage;
            if (damage > defender.Health) { damage = defender.Health; }
            return damage;
        }
    }
}
