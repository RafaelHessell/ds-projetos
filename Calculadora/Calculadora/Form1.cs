using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            double num1;
            double num2;

            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);

            double soma = num1 + num2;

            label5.Text = soma.ToString();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            double num1;
            double num2;

            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);

            double soma = num1 - num2;

            label5.Text = soma.ToString();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            double num1;
            double num2;

            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            

            double soma = num1 / num2;

            label5.Text = soma.ToString();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            double num1;
            double num2;

            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);

            double soma = num1 * num2;

            label5.Text = soma.ToString();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = " ";
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
