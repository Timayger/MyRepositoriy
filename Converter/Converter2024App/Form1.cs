using ConverterLib;
using System.ComponentModel;

namespace Converter2024App
{
    public partial class Form1 : Form
    {
        Manager cm = new Manager();
        private static bool VvodIsRight;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(cm.GetPhysicValuesList().ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(cm.GetMeasureList(comboBox1.Text).ToArray());
            comboBox2.SelectedIndex = 0;

            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(cm.GetMeasureList(comboBox1.Text).ToArray());
            comboBox3.SelectedIndex = 0;
        }
        private void UpdateText()
        {
            if (textBox1.Text != "")
            {
                try
                {
                    double num = double.Parse(textBox1.Text);
                    string valueName = comboBox1.Text;
                    string from = comboBox2.Text;
                    string to = comboBox3.Text;

                    textBox2.Text = cm.GetConvertedValue(num, valueName, from, to).ToString();
                    VvodIsRight = true;
                    textBox1.BackColor = Color.White;
                }
                catch (FormatException)
                {
                    VvodIsRight = false;
                    textBox1.BackColor = Color.LightCoral;

                }
            }
            else { textBox2.Clear(); textBox1.BackColor = Color.White; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateText();

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateText();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateText();

        }




        /*        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && !textBox1.Text.Contains(',')))
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.IndexOf(e.KeyChar));
                    }
                }*/
    }
}