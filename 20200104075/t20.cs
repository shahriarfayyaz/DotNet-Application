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
    public partial class t20 : Form
    {
        public t20()
        {
            InitializeComponent();
            logo.BackgroundImage = tiger.Images[0];
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 page = new Form1();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            details page = new details("Litton Das", 71, 1617, 23.43, 0, 0);
            page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            details page = new details("Shakib Al Hasan", 115, 2345, 23.68, 136, 20.78);
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            details page = new details("Najmul Hossain Shanto", 23, 548, 28.84, 0, 0);
            page.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            details page = new details("Mehidy Hasan Miraz", 23, 240, 15.00, 12, 38.75);
            page.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            details page = new details("Taskin Ahmed", 52, 115, 8.84, 48, 28.10);
            page.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            details page = new details("Mustafizur Rahman", 83, 68, 4.53, 100, 22.33);
            page.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            details page = new details("Hasan Mahmud", 16, 7, 3.50, 18, 23.61);
            page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            details page = new details("Towhid Hridoy", 6, 90, 18.00, 0, 0);
            page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            details page = new details("Rony Talukdar", 7, 200, 28.57, 0, 0);
            page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            details page = new details("Afif Hossain", 62, 1020, 21.25, 9, 24.00);
            page.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            details page = new details("Shamim Hossain", 15, 205, 20.50, 0, 0);
            page.Show();
        }
    }
}
