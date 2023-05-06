using System.Windows.Forms;

namespace ZADACHA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Массив точек треугольника.
            Point[] points = new Point[3];
            points[0].X = 10; points[0].Y = 10;
            points[1].X = 100; points[1].Y = 200;
            points[2].X = 30; points[2].Y = 150;

            // Изображение, которое будем вставлять в PictureBox.
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics grfx = Graphics.FromImage(bmp))
            {
                // Рисуем.
                grfx.Clear(Color.White);
                grfx.DrawPolygon(Pens.Black, points);
            }
        }
    }
}