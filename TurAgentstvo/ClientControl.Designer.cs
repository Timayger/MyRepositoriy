namespace TurAgentstvo
{
    partial class ClientControl
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
            groupBox1 = new GroupBox();
            btnControl = new Button();
            btnBack = new Button();
            label11 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            radioButton2 = new RadioButton();
            phone = new TextBox();
            email = new TextBox();
            radioButton1 = new RadioButton();
            country = new TextBox();
            nomer = new TextBox();
            seriya = new TextBox();
            patronymic = new TextBox();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            label3 = new Label();
            surname = new TextBox();
            birth_date = new DateTimePicker();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btnControl);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.ForeColor = Color.BlueViolet;
            groupBox1.Location = new Point(35, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(758, 677);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление клиента";
            // 
            // btnControl
            // 
            btnControl.BackColor = SystemColors.ButtonHighlight;
            btnControl.Dock = DockStyle.Bottom;
            btnControl.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnControl.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnControl.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnControl.FlatStyle = FlatStyle.Flat;
            btnControl.Font = new Font("Times New Roman", 10.875F, FontStyle.Bold);
            btnControl.ForeColor = Color.FromArgb(0, 0, 64);
            btnControl.Location = new Point(3, 538);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(752, 68);
            btnControl.TabIndex = 12;
            btnControl.Text = "Добавить";
            btnControl.UseVisualStyleBackColor = false;
            btnControl.Click += btnControl_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.Dock = DockStyle.Bottom;
            btnBack.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnBack.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Times New Roman", 10.875F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(0, 0, 64);
            btnBack.Location = new Point(3, 606);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(752, 68);
            btnBack.TabIndex = 11;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Times New Roman", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.GhostWhite;
            label11.Location = new Point(6, 502);
            label11.Name = "label11";
            label11.Size = new Size(321, 31);
            label11.TabIndex = 9;
            label11.Text = "* — необязательные поля";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.64265F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5360231F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.8213272F));
            tableLayoutPanel1.Controls.Add(radioButton2, 2, 3);
            tableLayoutPanel1.Controls.Add(phone, 1, 9);
            tableLayoutPanel1.Controls.Add(email, 1, 8);
            tableLayoutPanel1.Controls.Add(radioButton1, 1, 3);
            tableLayoutPanel1.Controls.Add(country, 1, 6);
            tableLayoutPanel1.Controls.Add(nomer, 1, 5);
            tableLayoutPanel1.Controls.Add(seriya, 1, 4);
            tableLayoutPanel1.Controls.Add(patronymic, 1, 2);
            tableLayoutPanel1.Controls.Add(name, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(label10, 0, 9);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(surname, 1, 1);
            tableLayoutPanel1.Controls.Add(birth_date, 1, 7);
            tableLayoutPanel1.Location = new Point(6, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(694, 461);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Left;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(379, 143);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 35);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ж";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            phone.Anchor = AnchorStyles.Left;
            phone.BackColor = Color.GhostWhite;
            phone.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(phone, 2);
            phone.ForeColor = Color.FromArgb(0, 0, 64);
            phone.Location = new Point(292, 418);
            phone.Name = "phone";
            phone.Size = new Size(399, 39);
            phone.TabIndex = 20;
            phone.KeyPress += text_formation;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Left;
            email.BackColor = Color.GhostWhite;
            email.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(email, 2);
            email.ForeColor = Color.FromArgb(0, 0, 64);
            email.Location = new Point(292, 371);
            email.Name = "email";
            email.Size = new Size(399, 39);
            email.TabIndex = 19;
            email.KeyPress += text_formation;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Left;
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.Blue;
            radioButton1.Location = new Point(292, 143);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 35);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "М";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // country
            // 
            country.Anchor = AnchorStyles.Left;
            country.BackColor = Color.GhostWhite;
            country.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(country, 2);
            country.ForeColor = Color.FromArgb(0, 0, 64);
            country.Location = new Point(292, 279);
            country.Name = "country";
            country.Size = new Size(399, 39);
            country.TabIndex = 17;
            country.KeyPress += text_formation;
            // 
            // nomer
            // 
            nomer.Anchor = AnchorStyles.Left;
            nomer.BackColor = Color.GhostWhite;
            nomer.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(nomer, 2);
            nomer.ForeColor = Color.FromArgb(0, 0, 64);
            nomer.Location = new Point(292, 233);
            nomer.Name = "nomer";
            nomer.Size = new Size(399, 39);
            nomer.TabIndex = 16;
            nomer.KeyPress += text_formation;
            // 
            // seriya
            // 
            seriya.Anchor = AnchorStyles.Left;
            seriya.BackColor = Color.GhostWhite;
            seriya.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(seriya, 2);
            seriya.ForeColor = Color.FromArgb(0, 0, 64);
            seriya.Location = new Point(292, 187);
            seriya.Name = "seriya";
            seriya.Size = new Size(399, 39);
            seriya.TabIndex = 15;
            seriya.KeyPress += text_formation;
            // 
            // patronymic
            // 
            patronymic.Anchor = AnchorStyles.Left;
            patronymic.BackColor = Color.GhostWhite;
            patronymic.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(patronymic, 2);
            patronymic.ForeColor = Color.FromArgb(0, 0, 64);
            patronymic.Location = new Point(292, 95);
            patronymic.Name = "patronymic";
            patronymic.Size = new Size(399, 39);
            patronymic.TabIndex = 13;
            patronymic.KeyPress += text_formation;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Left;
            name.BackColor = Color.GhostWhite;
            name.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(name, 2);
            name.ForeColor = Color.FromArgb(0, 0, 64);
            name.Location = new Point(292, 3);
            name.Name = "name";
            name.Size = new Size(399, 39);
            name.TabIndex = 11;
            name.KeyPress += text_formation;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(145, 53);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 1;
            label2.Text = "Фамилия:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(209, 7);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 0;
            label1.Text = "Имя:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.ForeColor = Color.GhostWhite;
            label6.Location = new Point(64, 237);
            label6.Name = "label6";
            label6.Size = new Size(222, 31);
            label6.TabIndex = 5;
            label6.Text = "Номер паспорта:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(65, 191);
            label5.Name = "label5";
            label5.Size = new Size(221, 31);
            label5.TabIndex = 4;
            label5.Text = "Серия паспорта:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.ForeColor = Color.GhostWhite;
            label7.Location = new Point(9, 283);
            label7.Name = "label7";
            label7.Size = new Size(277, 31);
            label7.TabIndex = 6;
            label7.Text = "Страна проживания:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = Color.GhostWhite;
            label8.Location = new Point(77, 329);
            label8.Name = "label8";
            label8.Size = new Size(209, 31);
            label8.TabIndex = 5;
            label8.Text = "Дата рождения:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = Color.GhostWhite;
            label9.Location = new Point(184, 375);
            label9.Name = "label9";
            label9.Size = new Size(102, 31);
            label9.TabIndex = 7;
            label9.Text = "E-mail:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = Color.GhostWhite;
            label10.Location = new Point(145, 422);
            label10.Name = "label10";
            label10.Size = new Size(141, 31);
            label10.TabIndex = 8;
            label10.Text = "*Телефон:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(213, 145);
            label4.Name = "label4";
            label4.Size = new Size(73, 31);
            label4.TabIndex = 3;
            label4.Text = "Пол:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(136, 99);
            label3.Name = "label3";
            label3.Size = new Size(150, 31);
            label3.TabIndex = 2;
            label3.Text = "*Отчество:";
            // 
            // surname
            // 
            surname.Anchor = AnchorStyles.Left;
            surname.BackColor = Color.GhostWhite;
            surname.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(surname, 2);
            surname.ForeColor = Color.FromArgb(0, 0, 64);
            surname.Location = new Point(292, 49);
            surname.Name = "surname";
            surname.Size = new Size(399, 39);
            surname.TabIndex = 12;
            surname.KeyPress += text_formation;
            // 
            // birth_date
            // 
            birth_date.CalendarForeColor = Color.FromArgb(0, 0, 64);
            tableLayoutPanel1.SetColumnSpan(birth_date, 2);
            birth_date.Location = new Point(292, 325);
            birth_date.Name = "birth_date";
            birth_date.Size = new Size(399, 39);
            birth_date.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 720);
            panel1.TabIndex = 0;
            // 
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 720);
            Controls.Add(panel1);
            Name = "ClientControl";
            Text = "AddClient";
            Load += ClientControl_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox phone;
        private TextBox email;
        private TextBox country;
        private TextBox nomer;
        private TextBox seriya;
        private TextBox patronymic;
        private TextBox surname;
        private TextBox name;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Button btnBack;
        private Button btnControl;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker birth_date;
    }
}