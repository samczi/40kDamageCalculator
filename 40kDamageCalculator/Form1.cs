namespace _40kDamageCalculator
{
    public partial class Form1 : Form
    {
        private Attacker _attacker;
        public Form1()
        {
            InitializeComponent();
            _attacker = new Attacker(0,0,0,0,0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void attacksNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hitChanceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void strengthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void apComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void damageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
