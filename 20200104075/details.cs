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
    public partial class details : Form
    {
        public details()
        {
            InitializeComponent();
        }
        public details(string n , int ma, int ru , double avg , int wic, double wavg)
        {
            InitializeComponent();
            name.Text = n;
            matchess.Text = Convert.ToString(ma);
            average.Text = Convert.ToString(avg);
            runs.Text = Convert.ToString(ru);
            wicket.Text = Convert.ToString(wic);
            wicaverage.Text = Convert.ToString(wavg);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void matchess_Click(object sender, EventArgs e)
        {

        }
    }
}
