namespace ZADACHA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val1, val2, val3, res;
            val1 = textBox1.Text;
            val2 = textBox2.Text;
            val3 = textBox3.Text;

            double X = double.Parse(val1);
            double Y = double.Parse(val2);
            double Z = double.Parse(val3);

            if(Z - X == 0)
            {
                double ress = Y * Math.Sin(X) + Z;
                textBox4.Text = ress.ToString();
            }
            else if(Z - X < 0)
            {
                double ress = Y * Math.Pow(Math.E, Math.Sin(X)) - Z;
                textBox4.Text = ress.ToString();
            }
            else if(Z - X > 0)
            {
                double ress = Y * Math.Sin(Math.Sin(X)) + Z;
                textBox4.Text = ress.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}