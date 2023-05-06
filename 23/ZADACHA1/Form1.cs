using System;
using System.Globalization;

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
            
            var items = listBox1.Items;
            foreach (var item in items)
            {
                if (!string.IsNullOrEmpty(item.ToString()))
                {
                    OutputChars(item?.ToString());
                }
                
            }
            
        }

        private void OutputChars(string? input)
        {
            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    label1.Text += c.ToString();
                }
            }
        }
    }
}