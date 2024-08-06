using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40kDamageCalculator
{
    internal partial class Form2 : Form
    {
        Calculations _calculations;
        public Form2(Calculations calculations)
        {
            InitializeComponent();
            _calculations = calculations;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            damageTextBox.Text = _calculations.Attacker.Damage.ToString();
            attacksTextBox.Text = _calculations.Attacker.Attacks.ToString();
            hitChanceTextBox.Text = _calculations.Attacker.HitChance.ToString();
            apTextBox.Text = _calculations.Attacker.ArmorPiercing.ToString();
            strengthTextBox.Text = _calculations.Attacker.Strength.ToString();
            healthtextBox.Text = _calculations.Defender.Health.ToString();
            toughnesstextBox.Text = _calculations.Defender.Health.ToString();
            armorDefenderTextBox.Text = _calculations.Defender.Armor.ToString();
            invSaveTextBox.Text = _calculations.Defender.InvSave.ToString();
            fnpTextBox.Text = _calculations.Defender.FeelNoPain.ToString();
            _calculations.CalculateCombatRound();
            damageDealtTextBox.Text = _calculations.avgDamageToEnemy.ToString();
            modelsKilledTextBox.Text = _calculations.avgDeadModels.ToString();
        }
    }
}
