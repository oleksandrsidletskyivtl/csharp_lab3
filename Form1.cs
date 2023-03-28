namespace Obmin_valut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "=>";
            textBox3.Enabled = false;
            textBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kurs1, kurs2, suma, sum_out;
            kurs1 = double.Parse(textBox1.Text);
            kurs2 = double.Parse(textBox2.Text);
            if(radioButton1.Checked == true)
            {
                textBox4.Enabled = true;
                suma = double.Parse(textBox3.Text);
                sum_out = suma * kurs1;
                textBox4.Text = sum_out.ToString();
            }
            else
            {
                textBox3.Enabled = true;
                suma = double.Parse(textBox4.Text);
                sum_out = suma / kurs2;
                textBox3.Text = sum_out.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "<=";
        }
    }
}