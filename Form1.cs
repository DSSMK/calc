namespace calc
{
    public partial class Form1 : Form
    {
        string opt = "";
        double reuslt = 0;
        bool isopt = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text == "0" || isopt == true)
            {
                textBox1.Clear();
            }
            if (but.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but.Text; }
            }
            else { textBox1.Text = textBox1.Text + but.Text; }
            isopt = false;

        }
        private void button13_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            opt = but.Text;
            reuslt = Convert.ToDouble(textBox1.Text);
            isopt = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (opt)
            {
                case "+":
                    textBox1.Text = (reuslt + Convert.ToDouble(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (reuslt - Convert.ToDouble(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (reuslt * Convert.ToDouble(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (reuslt / Convert.ToDouble(textBox1.Text)).ToString();
                    break;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            reuslt = 0;
        }
    }
}
