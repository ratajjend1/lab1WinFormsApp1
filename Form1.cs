using lab1dll;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        calculate cal;
        public Form1()
        {
            cal = new calculate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = cal.add(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            textBox4.Text = cal.subtract(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = cal.subtract(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
