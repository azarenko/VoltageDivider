namespace VoltageDivider
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.power_value = new System.Windows.Forms.TextBox();
            this.divider_value = new System.Windows.Forms.TextBox();
            this.R1_Value = new System.Windows.Forms.Label();
            this.R2_Value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.current_value = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nominal_number = new System.Windows.Forms.ComboBox();
            this.calc = new System.Windows.Forms.Button();
            this.ground_value = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // power_value
            // 
            this.power_value.Location = new System.Drawing.Point(62, 8);
            this.power_value.MaxLength = 8;
            this.power_value.Name = "power_value";
            this.power_value.Size = new System.Drawing.Size(34, 20);
            this.power_value.TabIndex = 0;
            this.power_value.Text = "5";
            // 
            // divider_value
            // 
            this.divider_value.Location = new System.Drawing.Point(83, 161);
            this.divider_value.MaxLength = 8;
            this.divider_value.Name = "divider_value";
            this.divider_value.Size = new System.Drawing.Size(34, 20);
            this.divider_value.TabIndex = 1;
            this.divider_value.Text = "2,5";
            // 
            // R1_Value
            // 
            this.R1_Value.AutoSize = true;
            this.R1_Value.Location = new System.Drawing.Point(89, 83);
            this.R1_Value.Name = "R1_Value";
            this.R1_Value.Size = new System.Drawing.Size(0, 13);
            this.R1_Value.TabIndex = 2;
            // 
            // R2_Value
            // 
            this.R2_Value.AutoSize = true;
            this.R2_Value.Location = new System.Drawing.Point(89, 267);
            this.R2_Value.Name = "R2_Value";
            this.R2_Value.Size = new System.Drawing.Size(0, 13);
            this.R2_Value.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mkA";
            // 
            // current_value
            // 
            this.current_value.Location = new System.Drawing.Point(122, 8);
            this.current_value.MaxLength = 8;
            this.current_value.Name = "current_value";
            this.current_value.Size = new System.Drawing.Size(56, 20);
            this.current_value.TabIndex = 9;
            this.current_value.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nominal number";
            // 
            // nominal_number
            // 
            this.nominal_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nominal_number.Items.AddRange(new object[] {
            "E3",
            "E6",
            "E12",
            "E24",
            "E48",
            "E96",
            "E192"});
            this.nominal_number.Location = new System.Drawing.Point(258, 161);
            this.nominal_number.Name = "nominal_number";
            this.nominal_number.Size = new System.Drawing.Size(54, 21);
            this.nominal_number.TabIndex = 15;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(196, 194);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(116, 23);
            this.calc.TabIndex = 16;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // ground_value
            // 
            this.ground_value.Location = new System.Drawing.Point(39, 358);
            this.ground_value.MaxLength = 8;
            this.ground_value.Name = "ground_value";
            this.ground_value.Size = new System.Drawing.Size(34, 20);
            this.ground_value.TabIndex = 17;
            this.ground_value.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "V";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VoltageDivider.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(324, 390);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ground_value);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.nominal_number);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.current_value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R2_Value);
            this.Controls.Add(this.R1_Value);
            this.Controls.Add(this.divider_value);
            this.Controls.Add(this.power_value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Voltage divider (by Azarenko S.A.)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox power_value;
        private System.Windows.Forms.TextBox divider_value;
        private System.Windows.Forms.Label R1_Value;
        private System.Windows.Forms.Label R2_Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox current_value;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox nominal_number;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox ground_value;
        private System.Windows.Forms.Label label9;
    }
}

