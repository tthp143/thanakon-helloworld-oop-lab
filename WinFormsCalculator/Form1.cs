namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Num1 = num1.Text;
            var Num2 = num2.Text;

            double n1 = Double.Parse(Num1);
            double n2 = Double.Parse(Num2);
            double sum = n1 + n2;

            result.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Num1 = num1.Text;
            var Num2 = num2.Text;

            double n1 = Double.Parse(Num1);
            double n2 = Double.Parse(Num2);
            double sum = n1 - n2;

            result.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Num1 = num1.Text;
            var Num2 = num2.Text;

            double n1 = Double.Parse(Num1);
            double n2 = Double.Parse(Num2);
            double sum = n1 * n2;

            result.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Num1 = num1.Text;
            var Num2 = num2.Text;

            double n1 = Double.Parse(Num1);
            double n2 = Double.Parse(Num2);
            double sum = n1 / n2;

            result.Text = sum.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            result.Text = "";
        }
    }
}
