namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1, num2;
        string operation;
        bool ActiveNum;
        bool ActiveAct;
        bool ActiveZ;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNums(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (ActiveNum == false)
                textBox1.Clear();

            if (b.Text == "," && ActiveZ == false)
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

            if (ActiveAct == false)
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
                            MessageBox.Show("Делить на ноль нельзя!",
                                            "Сообщение",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        else
                            textBox1.Text = (num1 / num2).ToString();
                        break;
                    default:
                        break;
                }
                ActiveNum = false;
                ActiveAct = false;
                ActiveZ = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            
        }
    }
}
