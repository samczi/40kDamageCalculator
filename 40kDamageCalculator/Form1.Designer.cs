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
            groupBox2 = new GroupBox();
            hitChanceComboBox = new ComboBox();
            apComboBox = new ComboBox();
            label1 = new Label();
            attacksNumericUpDown = new NumericUpDown();
            strengthNumericUpDown = new NumericUpDown();
            damageNumericUpDown = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attacksNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)damageNumericUpDown).BeginInit();
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
            // groupBox2
            // 
            groupBox2.Location = new Point(403, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 409);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Defender Stats";
            // 
            // hitChanceComboBox
            // 
            hitChanceComboBox.FormattingEnabled = true;
            hitChanceComboBox.Location = new Point(6, 51);
            hitChanceComboBox.Name = "hitChanceComboBox";
            hitChanceComboBox.Size = new Size(69, 23);
            hitChanceComboBox.TabIndex = 2;
            hitChanceComboBox.SelectedIndexChanged += hitChanceComboBox_SelectedIndexChanged;
            // 
            // apComboBox
            // 
            apComboBox.FormattingEnabled = true;
            apComboBox.Location = new Point(6, 109);
            apComboBox.Name = "apComboBox";
            apComboBox.Size = new Size(69, 23);
            apComboBox.TabIndex = 3;
            apComboBox.SelectedIndexChanged += apComboBox_SelectedIndexChanged;
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
            // attacksNumericUpDown
            // 
            attacksNumericUpDown.Location = new Point(6, 22);
            attacksNumericUpDown.Name = "attacksNumericUpDown";
            attacksNumericUpDown.Size = new Size(69, 23);
            attacksNumericUpDown.TabIndex = 5;
            attacksNumericUpDown.ValueChanged += attacksNumericUpDown_ValueChanged;
            // 
            // strengthNumericUpDown
            // 
            strengthNumericUpDown.Location = new Point(6, 80);
            strengthNumericUpDown.Name = "strengthNumericUpDown";
            strengthNumericUpDown.Size = new Size(69, 23);
            strengthNumericUpDown.TabIndex = 6;
            strengthNumericUpDown.ValueChanged += strengthNumericUpDown_ValueChanged;
            // 
            // damageNumericUpDown
            // 
            damageNumericUpDown.Location = new Point(6, 138);
            damageNumericUpDown.Name = "damageNumericUpDown";
            damageNumericUpDown.Size = new Size(69, 23);
            damageNumericUpDown.TabIndex = 7;
            damageNumericUpDown.ValueChanged += damageNumericUpDown_ValueChanged;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 54);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Hit Chance";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 140);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "Damage";
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
            ((System.ComponentModel.ISupportInitialize)attacksNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)strengthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)damageNumericUpDown).EndInit();
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
    }
}
