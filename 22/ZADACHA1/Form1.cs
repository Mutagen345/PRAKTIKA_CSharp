namespace ZADACHA1
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
            
            double ress = X + Y + Z;

            textBox4.Text = ress.ToString();
        }
    }
}