﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            logo.BackgroundImage = tiger.Images[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            test page = new test();
            page.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            odi page = new odi();
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            t20 page = new t20();
            page.Show();
        }
    }
}
