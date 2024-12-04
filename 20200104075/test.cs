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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            logo.BackgroundImage = tiger.Images[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            details page = new details("Tamim Iqbal" , 70 , 5134 , 38.89 , 0, 0);
            page.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 page = new Form1();
            page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            details page = new details("Shakib Al Hasan", 66, 4454, 39.07, 233, 31.06);
            page.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            details page = new details("Najmul Hossain Shanto", 33, 1013, 24.70, 0, 0);
            page.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            details page = new details("Mominul Haque", 56, 3655, 37.68, 7, 68.85);
            page.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            details page = new details("Mushfiqur Rahim", 85, 5498, 38.44, 0, 0);
            page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            details page = new details("Litton Das", 38, 2319, 35.67, 0, 0);
            page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            details page = new details("Mehidy Hasan Miraz", 38, 1197, 19.00, 148, 33.98);
            page.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            details page = new details("Taijul Islam", 41, 537, 8.95, 175, 32.38);
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            details page = new details("Taskin Ahmed", 12, 219, 12.16, 26, 56.15);
            page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            details page = new details("Ebadot Hossain", 19, 50, 3.12, 37, 51.64);
            page.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            details page = new details("Mustafizur Rahman", 15, 66, 4.40, 31, 36.74);
            page.Show();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
