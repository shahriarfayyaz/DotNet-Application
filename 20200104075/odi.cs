using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200104075
{
    public partial class odi : Form
    {
        public odi()
        {
            InitializeComponent();
            logo.BackgroundImage = tiger.Images[0];
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 page = new Form1();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            details page = new details("Tamim Iqbal", 240, 8300, 36.72, 0, 0);
            page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            details page = new details("Litton Das", 69, 2121, 33.66, 0, 0);
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            details page = new details("Najmul Hossain Shanto", 24, 615, 26.73, 1, 23.00);
            page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            details page = new details("Towhid Hridoy", 6, 249, 49.80, 0, 0);
            page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            details page = new details("Mushfiqur Rahim", 248, 7187, 37.23, 0, 0);
            page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            details page = new details("Shakib Al Hasan", 232, 7132, 37.73, 301, 29.12);
            page.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            details page = new details("Mahmudullah Riyad", 218, 4950, 35.35, 82, 45.26);
            page.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            details page = new details("Mehidy Hasan Miraz", 74, 858, 22.00, 85, 33.02);
            page.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            details page = new details("Taskin Ahmed", 57, 142, 7.47, 78, 30.91);
            page.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            details page = new details("Mustafizur Rahman", 87, 106, 6.62, 146, 24.48);
            page.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            details page = new details("Hasan Mahmud", 11, 6, 1.50, 18, 22.27);
            page.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
