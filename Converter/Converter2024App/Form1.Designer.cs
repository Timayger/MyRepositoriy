namespace Converter2024App
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(70, 35);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(318, 45);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(70, 118);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(318, 50);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Info;
            comboBox2.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(70, 169);
            comboBox2.Margin = new Padding(5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(318, 45);
            comboBox2.TabIndex = 3;
            comboBox2.Click += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.Info;
            comboBox3.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(459, 169);
            comboBox3.Margin = new Padding(5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(318, 45);
            comboBox3.TabIndex = 5;
            comboBox3.Click += comboBox3_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Maroon;
            textBox2.Location = new Point(459, 118);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 50);
            textBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(400, 114);
            label5.Name = "label5";
            label5.Size = new Size(51, 54);
            label5.TabIndex = 10;
            label5.Text = "=";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(70, 85);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 11;
            label1.Text = "Введите число:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(838, 302);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label1;
    }
}