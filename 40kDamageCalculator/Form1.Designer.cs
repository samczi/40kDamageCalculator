namespace _40kDamageCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            damageNumericUpDown = new NumericUpDown();
            strengthNumericUpDown = new NumericUpDown();
            attacksNumericUpDown = new NumericUpDown();
            label1 = new Label();
            apComboBox = new ComboBox();
            hitChanceComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            feelNoPainComboBox = new ComboBox();
            label10 = new Label();
            invSaveComboBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            armorComboBox = new ComboBox();
            label9 = new Label();
            HealthNumericUpDown = new NumericUpDown();
            toughnessNumericUpDown = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)damageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attacksNumericUpDown).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HealthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toughnessNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calculate Average Damage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(damageNumericUpDown);
            groupBox1.Controls.Add(strengthNumericUpDown);
            groupBox1.Controls.Add(attacksNumericUpDown);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(apComboBox);
            groupBox1.Controls.Add(hitChanceComboBox);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 409);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Attacker Stats";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 140);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "Damage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 112);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 10;
            label4.Text = "Ap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 54);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Hit Chance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 82);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 8;
            label2.Text = "Strength";
            // 
            // damageNumericUpDown
            // 
            damageNumericUpDown.Location = new Point(6, 138);
            damageNumericUpDown.Name = "damageNumericUpDown";
            damageNumericUpDown.Size = new Size(69, 23);
            damageNumericUpDown.TabIndex = 7;
            damageNumericUpDown.ValueChanged += damageNumericUpDown_ValueChanged;
            // 
            // strengthNumericUpDown
            // 
            strengthNumericUpDown.Location = new Point(6, 80);
            strengthNumericUpDown.Name = "strengthNumericUpDown";
            strengthNumericUpDown.Size = new Size(69, 23);
            strengthNumericUpDown.TabIndex = 6;
            strengthNumericUpDown.ValueChanged += strengthNumericUpDown_ValueChanged;
            // 
            // attacksNumericUpDown
            // 
            attacksNumericUpDown.Location = new Point(6, 22);
            attacksNumericUpDown.Name = "attacksNumericUpDown";
            attacksNumericUpDown.Size = new Size(69, 23);
            attacksNumericUpDown.TabIndex = 5;
            attacksNumericUpDown.ValueChanged += attacksNumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Attacks";
            // 
            // apComboBox
            // 
            apComboBox.FormattingEnabled = true;
            apComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            apComboBox.Location = new Point(6, 109);
            apComboBox.Name = "apComboBox";
            apComboBox.Size = new Size(69, 23);
            apComboBox.TabIndex = 3;
            apComboBox.SelectedIndexChanged += apComboBox_SelectedIndexChanged;
            // 
            // hitChanceComboBox
            // 
            hitChanceComboBox.FormattingEnabled = true;
            hitChanceComboBox.Items.AddRange(new object[] { "6", "5", "4", "3", "2" });
            hitChanceComboBox.Location = new Point(6, 51);
            hitChanceComboBox.Name = "hitChanceComboBox";
            hitChanceComboBox.Size = new Size(69, 23);
            hitChanceComboBox.TabIndex = 2;
            hitChanceComboBox.SelectedIndexChanged += hitChanceComboBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(feelNoPainComboBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(invSaveComboBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(armorComboBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(HealthNumericUpDown);
            groupBox2.Controls.Add(toughnessNumericUpDown);
            groupBox2.Location = new Point(403, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 409);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Defender Stats";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 141);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 25;
            label8.Text = "Feel No Pain";
            // 
            // feelNoPainComboBox
            // 
            feelNoPainComboBox.FormattingEnabled = true;
            feelNoPainComboBox.Items.AddRange(new object[] { "7", "6", "5", "4", "3", "2" });
            feelNoPainComboBox.Location = new Point(7, 138);
            feelNoPainComboBox.Name = "feelNoPainComboBox";
            feelNoPainComboBox.Size = new Size(69, 23);
            feelNoPainComboBox.TabIndex = 24;
            feelNoPainComboBox.SelectedIndexChanged += feelNoPainComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 112);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 23;
            label10.Text = "Invulnerable Save";
            // 
            // invSaveComboBox
            // 
            invSaveComboBox.FormattingEnabled = true;
            invSaveComboBox.Items.AddRange(new object[] { "7", "6", "5", "4", "3", "2" });
            invSaveComboBox.Location = new Point(7, 109);
            invSaveComboBox.Name = "invSaveComboBox";
            invSaveComboBox.Size = new Size(69, 23);
            invSaveComboBox.TabIndex = 22;
            invSaveComboBox.SelectedIndexChanged += invSaveComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 24);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 21;
            label6.Text = "Health";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 83);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 20;
            label7.Text = "Armor";
            // 
            // armorComboBox
            // 
            armorComboBox.FormattingEnabled = true;
            armorComboBox.Items.AddRange(new object[] { "7", "6", "5", "4", "3", "2" });
            armorComboBox.Location = new Point(7, 80);
            armorComboBox.Name = "armorComboBox";
            armorComboBox.Size = new Size(69, 23);
            armorComboBox.TabIndex = 13;
            armorComboBox.SelectedIndexChanged += armorComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 53);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 18;
            label9.Text = "Toughness";
            // 
            // HealthNumericUpDown
            // 
            HealthNumericUpDown.Location = new Point(7, 22);
            HealthNumericUpDown.Name = "HealthNumericUpDown";
            HealthNumericUpDown.Size = new Size(69, 23);
            HealthNumericUpDown.TabIndex = 17;
            HealthNumericUpDown.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // toughnessNumericUpDown
            // 
            toughnessNumericUpDown.Location = new Point(7, 51);
            toughnessNumericUpDown.Name = "toughnessNumericUpDown";
            toughnessNumericUpDown.Size = new Size(69, 23);
            toughnessNumericUpDown.TabIndex = 16;
            toughnessNumericUpDown.ValueChanged += toughnessNumericUpDown_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)damageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)attacksNumericUpDown).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HealthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)toughnessNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox apComboBox;
        private ComboBox hitChanceComboBox;
        private NumericUpDown attacksNumericUpDown;
        private NumericUpDown strengthNumericUpDown;
        private Label label3;
        private Label label2;
        private NumericUpDown damageNumericUpDown;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox armorComboBox;
        private Label label9;
        private NumericUpDown HealthNumericUpDown;
        private NumericUpDown toughnessNumericUpDown;
        private Label label10;
        private ComboBox invSaveComboBox;
        private Label label8;
        private ComboBox feelNoPainComboBox;
    }
}
