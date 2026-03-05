using lab1dll;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        calculate cal;
        public Form1()
        {
            cal = new calculate();
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "dziala";//cal.add(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            textBox4.Text = cal.subtract(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
