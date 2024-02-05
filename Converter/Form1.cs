using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {       
        private static bool listboxActive1;
        private static bool listboxActive2;
        private static bool listboxActive3;
        private static bool listboxActive4;
        private static bool TimeOfDlina = true;
        private static bool TimeOfVes;
        private static string velichina1_dlina = "мм";
        private static string velichina2_dlina = "мм";
        private static string velichina1_massa = "мг";
        private static string velichina2_massa = "мг";
        private static bool VvodIsRight;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            button1.Text = velichina1_dlina + "⁝";
            button2.Text = velichina2_dlina + "⁝";
            textBox1.Text = "1";
            textBox2.Text = "1";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            velichina1_dlina = lb.Text;
            button1.Text = velichina1_dlina + "⁝";
            if (textBox1.Text != "" && VvodIsRight)
            {
                switch (velichina1_dlina)
                {
                    case "мм":
                        switch (velichina2_dlina)
                        {
                            case "мм":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "см":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                break;

                            case "дм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.01);
                                break;

                            case "м":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;

                            case "км":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                break;
                        }
                        break;

                    case "см":
                        switch (velichina2_dlina)
                        {
                            case "см":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                break;

                            case "дм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                break;

                            case "м":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.01);
                                break;

                            case "км":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.00001);
                                break;
                        }
                        break;

                    case "дм":
                        switch (velichina2_dlina)
                        {
                            case "дм":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100);
                                break;

                            case "см":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                break;

                            case "м":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                break;

                            case "км":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.0001);
                                break;
                        }
                        break;

                    case "м":
                        switch (velichina2_dlina)
                        {
                            case "м":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;

                            case "см":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100);
                                break;

                            case "дм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                break;

                            case "км":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;
                        }
                        break;

                    case "км":
                        switch (velichina2_dlina)
                        {
                            case "км":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                break;

                            case "см":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100000);
                                break;

                            case "дм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10000);
                                break;

                            case "м":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;
                        }
                        break;
                }
            }
            
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            velichina2_dlina = lb.Text;
            button2.Text = velichina2_dlina + "⁝";
            if (textBox1.Text != "" && VvodIsRight)
            {
                switch (velichina2_dlina)
                {
                    case "мм":
                        switch (velichina1_dlina)
                        {
                            case "мм":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "см":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                break;

                            case "дм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100);
                                break;

                            case "м":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;

                            case "км":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                break;
                        }
                        break;

                    case "см":
                        switch (velichina1_dlina)
                        {
                            case "см":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                break;

                            case "дм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                break;

                            case "м":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100);
                                break;

                            case "км":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100000);
                                break;
                        }
                        break;

                    case "дм":
                        switch (velichina1_dlina)
                        {
                            case "дм":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.01);
                                break;

                            case "см":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                break;

                            case "м":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                break;

                            case "км":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10000);
                                break;
                        }
                        break;

                    case "м":
                        switch (velichina1_dlina)
                        {
                            case "м":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;

                            case "см":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.01);
                                break;

                            case "дм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                break;

                            case "км":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;
                        }
                        break;

                    case "км":
                        switch (velichina1_dlina)
                        {
                            case "км":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                break;

                            case "см":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.00001);
                                break;

                            case "дм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.0001);
                                break;

                            case "м":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;
                        }
                        break;
                }
            }            

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            velichina1_massa = lb.Text;
            button1.Text = velichina1_massa + "⁝";
            if (textBox1.Text != "" && VvodIsRight)
            {
                switch (velichina1_massa)
                {
                    case "мг":
                        switch (velichina2_massa)
                        {
                            case "мг":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "гм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;

                            case "кг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                break;

                            case "т":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000000001);
                                break;
                        }
                        break;

                    case "гм":
                        switch (velichina2_massa)
                        {
                            case "гм":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;

                            case "кг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;

                            case "т":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                break;
                        }
                        break;

                    case "кг":
                        switch (velichina2_massa)
                        {
                            case "кг":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                break;

                            case "гм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;

                            case "т":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;
                        }
                        break;

                    case "т":
                        switch (velichina2_massa)
                        {
                            case "т":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000000);
                                break;

                            case "гм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                break;

                            case "кг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;
                        }
                        break;
                }
            }

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            velichina2_massa = lb.Text;
            button2.Text = velichina2_massa + "⁝";
            if (textBox1.Text != "" && VvodIsRight)
            {
                switch (velichina2_massa)
                {
                    case "мг":
                        switch (velichina1_massa)
                        {
                            case "мг":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "гм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;

                            case "кг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                break;

                            case "т":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000000);
                                break;
                        }
                        break;

                    case "гм":
                        switch (velichina1_massa)
                        {
                            case "гм":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;

                            case "кг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;

                            case "т":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                break;
                        }
                        break;

                    case "кг":
                        switch (velichina1_massa)
                        {
                            case "кг":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                break;

                            case "гм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;

                            case "т":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                break;
                        }
                        break;

                    case "т":
                        switch (velichina1_massa)
                        {
                            case "т":
                                textBox2.Text = textBox1.Text;
                                break;

                            case "мг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000000001);
                                break;

                            case "гм":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                break;

                            case "кг":
                                textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                break;
                        }
                        break;
                }
            }
        }
        private void btnOpen1(object sender, EventArgs e)
        {
            if (TimeOfDlina)
            {
                listboxActive1 = listBox1.Visible;
                if (listboxActive1)
                {
                    listBox1.Visible = false;
                }
                else
                {
                    listBox1.Visible = true;
                }
            }
            else if (TimeOfVes)
            {
                listboxActive3 = listBox3.Visible;
                if (listboxActive3)
                {
                    listBox3.Visible = false;
                }
                else
                {
                    listBox3.Visible = true;
                }
            }

        }

        private void btnOpen2(object sender, EventArgs e)
        {
            if (TimeOfDlina)
            {
                listboxActive2 = listBox2.Visible;
                if (listboxActive2)
                {
                    listBox2.Visible = false;
                }
                else
                {
                    listBox2.Visible = true;
                }
            }
            else if (TimeOfVes)
            {
                listboxActive4 = listBox4.Visible;
                if (listboxActive4)
                {
                    listBox4.Visible = false;
                }
                else
                {
                    listBox4.Visible = true;
                }
            }

        }

        private void btnUpdate(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Visible = false;
            listBox2.Visible = false;
            velichina1_dlina = "мм";
            velichina2_dlina = "мм";
            button1.Text = velichina2_dlina + "⁝";
            button2.Text = velichina2_dlina + "⁝";
            TimeOfVes = false;
            TimeOfDlina = true;
            button4.Text = "Длина";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
            if (textBox1.Text != "")
            {
                try
                {
                    double s = Convert.ToDouble(textBox1.Text);
                    label2.Text = "";
                    VvodIsRight = true;
                    if (TimeOfDlina)
                    {
                        switch (velichina1_dlina)
                        {
                            case "мм":
                                switch (velichina2_dlina)
                                {
                                    case "мм":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "см":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                        break;

                                    case "дм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.01);
                                        break;

                                    case "м":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                        break;

                                    case "км":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                        break;
                                }
                                break;

                            case "см":
                                switch (velichina2_dlina)
                                {
                                    case "см":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "мм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                        break;

                                    case "дм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                        break;

                                    case "м":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.01);
                                        break;

                                    case "км":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.00001);
                                        break;
                                }
                                break;

                            case "дм":
                                switch (velichina2_dlina)
                                {
                                    case "дм":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "мм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100);
                                        break;

                                    case "см":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                        break;

                                    case "м":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.1);
                                        break;

                                    case "км":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.0001);
                                        break;
                                }
                                break;

                            case "м":
                                switch (velichina2_dlina)
                                {
                                    case "м":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "мм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                        break;

                                    case "см":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100);
                                        break;

                                    case "дм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10);
                                        break;

                                    case "км":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                        break;
                                }
                                break;

                            case "км":
                                switch (velichina2_dlina)
                                {
                                    case "км":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "мм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                        break;

                                    case "см":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100000);
                                        break;

                                    case "дм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 10000);
                                        break;

                                    case "м":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                        break;
                                }
                                break;
                        }
                    }
                    else if (TimeOfVes)
                    {
                        switch (velichina1_massa)
                        {
                            case "мг":
                                switch (velichina2_massa)
                                {
                                    case "мг":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "гм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                        break;

                                    case "кг":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                        break;

                                    case "т":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000000001);
                                        break;
                                }
                                break;

                            case "гм":
                                switch (velichina2_massa)
                                {
                                    case "гм":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "мг":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                        break;

                                    case "кг":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                        break;

                                    case "т":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.000001);
                                        break;
                                }
                                break;

                            case "кг":
                                switch (velichina2_massa)
                                {
                                    case "кг":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "мг":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                        break;

                                    case "гм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                        break;

                                    case "т":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 0.001);
                                        break;
                                }
                                break;

                            case "т":
                                switch (velichina2_massa)
                                {
                                    case "т":
                                        textBox2.Text = textBox1.Text;
                                        break;

                                    case "мг":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000000);
                                        break;

                                    case "гм":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000);
                                        break;

                                    case "кг":
                                        textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000);
                                        break;
                                }
                                break;
                        }
                    }
                    
                }
                catch (System.FormatException)
                {
                    label2.Text = "Вводите только цифры";
                    VvodIsRight = false;                    
                }
            }
            else { label2.Text = ""; textBox2.Clear(); ; }
        }

        private void btnSmenaMera(object sender, EventArgs e)
        {
            listBox5.Visible = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listBox5.Visible = false;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            
            if (lb.Text == "Масса")
            {
                TimeOfDlina = false;
                TimeOfVes = true;
                button4.Text = "Масса";
                listBox1.Visible = false;
                listBox2.Visible = false;
                button1.Text = velichina1_massa + "⁝";
                button2.Text = velichina2_massa + "⁝";
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (lb.Text == "Длина")
            {
                TimeOfVes = false;
                TimeOfDlina = true;
                button4.Text = "Длина";
                listBox3.Visible = false;
                listBox4.Visible = false;
                button1.Text = velichina1_dlina + "⁝";
                button2.Text = velichina2_dlina + "⁝";
                textBox1.Clear();
                textBox2.Clear();
            }
            listBox5.Visible = false;

        }
    }
}
