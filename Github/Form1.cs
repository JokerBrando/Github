﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            textBox1.Text = "";
            textBox1.Focus();
            pictureBox1.Image = Image.FromFile("C:/1/2.jpg");
        }
    }
}
