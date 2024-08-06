namespace _40kDamageCalculator
{
    public partial class Form1 : Form
    {
        private Attacker _attacker;
        private Defender _defender;
        public Form1()
        {
            _attacker = new Attacker(0, 0, 0, 0, 0);
            _defender = new Defender(0, 0, 0, 0, 0, 0, null);
            InitializeComponent();
            attacksNumericUpDown.Value = 10;
            hitChanceComboBox.SelectedItem = "2";
            strengthNumericUpDown.Value = 10;
            apComboBox.SelectedItem = "0";
            damageNumericUpDown.Value = 3;
            HealthNumericUpDown.Value = 3;
            toughnessNumericUpDown.Value = 2;
            armorComboBox.SelectedItem = "7";
            invSaveComboBox.SelectedItem = "7";
            feelNoPainComboBox.SelectedItem = "7";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculations calculations = new Calculations(_attacker, _defender);
            Form2 form2 = new Form2(calculations);
            form2.ShowDialog();
        }
        private void attacksNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _attacker.ChangeAttacks((int)attacksNumericUpDown.Value);
        }

        private void hitChanceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _attacker.ChangeHitChance(int.Parse(hitChanceComboBox.SelectedItem.ToString()));
        }

        private void strengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _attacker.ChangeStrength((int)strengthNumericUpDown.Value);
        }

        private void apComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _attacker.ChangeArmorPiercing(int.Parse(apComboBox.SelectedItem.ToString()));
        }

        private void damageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _attacker.ChangeDamage((int)damageNumericUpDown.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _defender.ChangeHealth((int)HealthNumericUpDown.Value);
        }

        private void invSaveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _defender.ChangeInvSave(int.Parse(invSaveComboBox.SelectedItem.ToString()));
        }

        private void toughnessNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _defender.ChangeToughness((int)toughnessNumericUpDown.Value);
        }

        private void armorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _defender.ChangeArmor(int.Parse(armorComboBox.SelectedItem.ToString()));
        }

        private void feelNoPainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _defender.ChangeFeelNoPain(int.Parse(feelNoPainComboBox.SelectedItem.ToString()));
        }
    }
}
