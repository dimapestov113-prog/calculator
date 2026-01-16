namespace calculator
{
    public partial class Form1 : Form
    {
        float a, b, result;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonsNumber_Click(object sender, EventArgs e)
        {
            if (!(sender is Button button))
                return;
            int num = Convert.ToInt32(button.Text);
            textBox1.Text = textBox1.Text + num; 
        }
        private void buttonravno_Click(object sender, EventArgs e)
        {
            calculate();
        }
        private void calculate()
        {
            switch (result)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a % float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 1;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 2;
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 3;
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 4;
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 5;
        //}
        //private void button6_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 6;
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 7;
        //}
        //private void button8_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 8;
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 9;
        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = textBox1.Text + 0;
        //}

        private void buttonumnoj_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            result = 3;
            
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            result = 1;
        }

        private void buttonmunis_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            result = 2;
        }

        private void buttondellete_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
        }

        private void buttondelit_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            result = 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            result = 5;
        }
    }
}
