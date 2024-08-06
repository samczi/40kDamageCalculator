using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    internal class Calculations
    {
        public Attacker Attacker;
        public Defender Defender;
        public decimal avgDeadModels = 0;
        public decimal avgDamageToEnemy = 0;

        public Calculations(Attacker attacker, Defender defender)
        {
            this.Attacker = attacker;
            this.Defender = defender;
        }

        public void CalculateCombatRound()
        {
            int numberOfAttacks = 1;
            decimal avgDamage = Attacker.Damage * DetermineHitChance() * DetermineWoundChance() * DetermineBetterSave();
            for (int i = 0; i < Attacker.Attacks; i += numberOfAttacks)
            {
                numberOfAttacks = 1;
                while ((avgDamage * DetermineSaveChance(Defender.FeelNoPain) * numberOfAttacks) < Defender.Health)
                {
                    if (i + numberOfAttacks < Attacker.Attacks)
                    {
                        numberOfAttacks++;
                    }
                    else 
                    { 
                        avgDamageToEnemy += avgDamage * DetermineSaveChance(Defender.FeelNoPain) * numberOfAttacks;
                        break; 
                    }
                }
                avgDamageToEnemy += Defender.Health;
                avgDeadModels++;
            }

        }
        private decimal DetermineHitChance()
        {
            int hitChance = Attacker.HitChance;
            if      (hitChance == 6) { return 1m / 6m; }
            else if (hitChance == 5) { return 1m / 3m; }
            else if (hitChance == 4) { return 1m / 2m; }
            else if (hitChance == 3) { return 2m / 3m; }
            else if (hitChance == 2) { return 5m / 6m; }
            else if (hitChance == 1) { return 5m / 6m; }
            throw new ArgumentOutOfRangeException();
        }
        private decimal DetermineWoundChance()
        {
            decimal proportion = (decimal)Defender.Toughness / (decimal)Attacker.Strength;
            if      (proportion > 2 )    { return 1m / 6m; }
            else if (proportion > 1 )    { return 1m / 3m; }
            else if (proportion == 1 )   { return 1m / 2m; }
            else if (proportion > 0.5m ) { return 2m / 3m; }
            else                         { return 5m / 6m; }
        }
        private decimal DetermineBetterSave()
        {
            decimal armor = DetermineSaveChance(Defender.Armor + Attacker.ArmorPiercing);
            decimal invSave = DetermineSaveChance(Defender.InvSave);
            if (armor >= invSave) { return invSave; }
            else return armor;
        }
        private decimal DetermineSaveChance(decimal save)
        {
            if      (save > 6)  { return 1m; }
            else if (save == 6) { return 5m / 6m; }
            else if (save == 5) { return 2m / 3m; }
            else if (save == 4) { return 1m / 2m; }
            else if (save == 3) { return 1m / 3m; }
            else if (save <= 2) { return 1m / 6m; }
            throw new ArgumentOutOfRangeException();
        }
    }
}
