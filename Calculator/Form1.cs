namespace Calculator
{
    public partial class Form1 : Form
    {
        static double num1 = 0, num2 = 0;
        static string operation;
        static bool ActiveNum;
        static bool ActiveAct;
        static bool ActiveZ;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }
        private void btnNums(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (!ActiveNum)
                textBox1.Clear();

            if (b.Text == "," && !ActiveZ)
            {
                ActiveZ = true;
                if (textBox1.Text == "")
                    textBox1.Text += "0" + b.Text;
                else
                    textBox1.Text += b.Text;
            }
            else if (b.Text != ",")
            {
                textBox1.Text += b.Text;
            }
            ActiveNum = true;
        }

        private void btnAction(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text != "")
            {
                if (!ActiveAct)
                {
                    operation = b.Text;
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                }
                else
                {
                    operation = b.Text;
                    textBox1.Clear();
                }
                ActiveAct = true;
                ActiveZ = false;
            }
        }

        private void btnResult(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num2 = Convert.ToDouble(textBox1.Text);

                switch (operation)
                {
                    case "+":
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        textBox1.Text = (num1 - num2).ToString();
                        break;
                    case "*":
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        if (num2 == 0)
                            MessageBox.Show("Äåëèòü íà íîëü íåëüçÿ",
                                            "Ñîîáùåíèå",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        else
                            textBox1.Text = (num1 / num2).ToString();
                        break;
                    case "^":
                        textBox1.Text = (Math.Pow(num1, num2)).ToString();
                        break;
                    default:
                        break;
                }
                ActiveNum = false;
                ActiveAct = false;
                ActiveZ = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = 0;
            num2 = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Pow(num, 2));
        }
    }
}
