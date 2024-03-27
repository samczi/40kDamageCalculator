using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    internal class Defender
    {
        public int HitChance;
        public int Toughness;
        public int Health;
        public int Armor;
        public int InvSave;
        public int FeelNoPain;
        public List<string> UnitType;

        public Defender(int hitChance, int toughness, int health, int armor, int invSave, int feelNoPain, List<string> unitType)
        {
            HitChance = hitChance;
            Toughness = toughness;
            Health = health;
            Armor = armor;
            InvSave = invSave;
            FeelNoPain = feelNoPain;
            UnitType = unitType;
        }
    }
}
