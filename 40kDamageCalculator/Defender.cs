using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kDamageCalculator
{
    internal class Defender
    {
        public int HitChance { get; private set; }
        public int Toughness { get; private set; }
        public int Health { get; private set; }
        public int Armor { get; private set; }
        public int InvSave { get; private set; }
        public int FeelNoPain { get; private set; }
        public List<string> UnitType; //ToDo

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
        public void ChangeHitChance(int hitChance)
        {
            HitChance = hitChance;
        }
        public void ChangeToughness(int toughness)
        {
            Toughness = toughness;
        }
        public void ChangeHealth(int health)
        {
            Health = health;
        }
        public void ChangeArmor(int armor)
        {
            Armor = armor;
        }
        public void ChangeInvSave(int invSave)
        {
            InvSave = invSave;
        }
        public void ChangeFeelNoPain(int feelNoPain)
        {
            FeelNoPain = feelNoPain;
        }
    }
}
