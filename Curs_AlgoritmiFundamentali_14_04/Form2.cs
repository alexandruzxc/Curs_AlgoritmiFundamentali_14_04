﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_AlgoritmiFundamentali_14_04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cplx z1 = new Cplx();
            z1.init(1, 0);
            Cplx z2 = new Cplx();
            z2.init(0, 2);

            Cplx z3 = Engine.sum(z1, z2);

            textBox1.Text = z3.view();

            Cplx z4 = z1 + z2;

            textBox2.Text = z4.view();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 myForm3 = new Form3();
                myForm3.ShowDialog();
        }
    }
}
